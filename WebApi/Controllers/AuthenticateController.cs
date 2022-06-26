using DAL.DTOs;
using DAL.EF;
using DAL.Entities;
using DAL.Extentions;
using DAL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace WebApi.Controllers
{
    public class AuthenticateController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _token;
        private readonly IConfiguration _configuration;

        public AuthenticateController(IUserRepository userRepository, ITokenService tokenService, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _token = tokenService;
            _configuration = configuration;
        }

        [HttpPost("/register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO dto) 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(await UserExists(dto.Email))
            {
                return BadRequest("Email is exist!");
            }
            var hmac = new HMACSHA512();

            var user = new User
            {
                Email = dto.Email.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password)),
                PasswordSalt = hmac.Key
            };

            await _userRepository.Add(user);
            var result = await _userRepository.SaveAll();
            if(result != null)
                return Ok(new {
                    Status = "Success",
                    Message = "User created successfully!"
                });
            return BadRequest("Cannot create user");
        }

        [HttpPost("/login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var user = await _userRepository.GetUserByEmail(dto.Email);

            if (user == null)
                return Unauthorized("User is invalid!");

            var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password));

            for(int i=0 ; i<computedHash.Length; i++)
            {
                if(computedHash[i] != user.PasswordHash[i]){
                    return Unauthorized("Invalid password");
                }
            }

            var token = _token.CreateToken(user);
            var refreshToken = user.RefreshToken;
            if (refreshToken == null || DateTime.Now >= user.RefreshTokenExpiryTime)
            {
                refreshToken = _token.GenerateRefreshToken();
            }
                
            var RefreshTokenValidityInDays = int.Parse(_configuration["Tokens:RefreshTokenVailidityInDays"]);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(RefreshTokenValidityInDays);

            var result = await _userRepository.SaveAll();
            if(result)
                return Ok(new {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    RefreshToken = user.RefreshToken,
                    Expiration = token.ValidTo
                });
            return Unauthorized();
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken(TokenRequestDTO tokenRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid token");
            }

            var principal = _token.GetPrincipalFromExpiredToken(tokenRequest.AccessToken);
            var email = principal.GetEmail();
            var currentUser = await _userRepository.GetUserByEmail(email);

            if (currentUser == null)
                return BadRequest("Invalid user");

            var savedRefreshToken = currentUser.RefreshToken;
            var expireRefreshToken = currentUser.RefreshTokenExpiryTime;
            var currentTime = DateTime.Now;

            if (currentTime > expireRefreshToken)
                return BadRequest("Refresh Token is expired");
            if (savedRefreshToken != tokenRequest.RefreshToken)
                return BadRequest("Invalid refresh token");

            var newAccessToken = _token.CreateToken(currentUser);
            var newRefreshToken = _token.GenerateRefreshToken();

            currentUser.RefreshToken = newRefreshToken;
            var result = await _userRepository.SaveAll();
            if(result) 
                return Ok( new
                {
                    Token = newAccessToken,
                    RefreshToken = newRefreshToken
                });
            return BadRequest("Can not refresh token");
        }

        [HttpPost("revoke")]
        [Authorize]
        public async Task<IActionResult> Revoke()
        {
            var email = User.GetEmail();
            var currentUser = await _userRepository.GetUserByEmail(email);
            if (currentUser == null) return BadRequest();
            currentUser.RefreshToken = null;
            await _userRepository.SaveAll();
            return NoContent();
        }

        private async Task<bool> UserExists(string email)
        {
            var user = await _userRepository.GetUserByEmail(email);
            if(user == null) return false;
            return true;
        }
    }
}
