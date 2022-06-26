using AutoMapper;
using DAL.DTOs;
using DAL.EF;
using DAL.Entities;
using DAL.Extentions;
using DAL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace WebApi.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly IPhotoService _photoService;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository,IPhotoService photoService, IMapper mapper)
        {
            _userRepository = userRepository;
            _photoService = photoService;
            _mapper = mapper;
        }

        [HttpGet("user-and-photo")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsersAndPhoto()
        {
            var listUser = await _userRepository.GetUsersAndPhoto();
            var usersReturn = _mapper.Map<IEnumerable<MemberDTO>>(listUser);
            return Ok(usersReturn);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers([FromQuery] UserParams userParams)
        {
            var email = User.GetEmail();
            var user = await _userRepository.GetUserByEmail(email);
            userParams.CurrentUserEmail = user.Email;

            if (string.IsNullOrEmpty(userParams.Gender))
            {
                userParams.Gender = user.Gender == "male" ? "female" : "male";
            }

            var users = await _userRepository.GetUsers(userParams);
            Response.AddPaginationHeader(users.CurrentPage, users.PageSize, 
                users.TotalCount, users.TotalPage);

            return Ok(users);
        }

        [HttpGet("user-and-photo-by-email")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersAndPhotosByEmail(string email)
        {
            var listUser = await _userRepository.GetUserByEmail(email);
            return Ok(listUser);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _userRepository.Get(id);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(MemberDTO update)
        {
            var username = User.GetEmail();
            var user = await _userRepository.GetUserByEmail(username);

            _mapper.Map(update, user);

            _userRepository.Update(user);
            if(await _userRepository.SaveAll()) return NoContent();
            return BadRequest("Failed to update user");
        }

        [HttpPost("add-photo")]
        public async Task<ActionResult<PhotoDTO>> AddPhoto(IFormFile file)
        {
            var user = await _userRepository.GetUserByEmail(User.GetEmail());

            var result = await _photoService.AddPhotoAsync(file);

            if(result.Error != null) return BadRequest(result.Error.Message);

            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId,
            };

            if(user.Photos.Count == 0)
            {
                photo.IsMain = true;
            }

            user.Photos.Add(photo); 
            if(await _userRepository.SaveAll())
            {
                return _mapper.Map<PhotoDTO>(photo);
            }
            return BadRequest("Cannot adding photo");
        }

        [HttpPut("set-main-photo/{photoId}")]
        public async Task<ActionResult<PhotoDTO>> SetMainPhoto(int photoId)
        {
            var user = await _userRepository.GetUserByEmail(User.GetEmail());

            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);
            if (photo == null) return BadRequest("Photo is not exsisted!");
            if (photo.IsMain) return BadRequest("This photo is already your main photo");
            
            var currentMainPhoto = user.Photos.FirstOrDefault(x => x.IsMain);
            if (currentMainPhoto != null) currentMainPhoto.IsMain = false;
            photo.IsMain = true;
            if (await _userRepository.SaveAll())
            {
                return NoContent();
            }
            return BadRequest("Cannot set main photo");
        }

        [HttpPut("delete-photo/{photoId}")]
        public async Task<ActionResult<PhotoDTO>> DeletePhoto(int photoId)
        {
            var user = await _userRepository.GetUserByEmail(User.GetEmail());

            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);
            if (photo == null) return NotFound();
            if (photo.IsMain) return BadRequest("Can not delete your main photo");
            if(photo.PublicId != null)
            {
                var result = await _photoService.DeletePhotoAsync(photo.PublicId);
                if (result.Error != null) return BadRequest(result.Error.Message);
            }
            user.Photos.Remove(photo);
            if (await _userRepository.SaveAll())
            {
                return Ok();
            }
            return BadRequest("Fail to delete");
        }




    }
}