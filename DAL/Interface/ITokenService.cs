using DAL.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DAL.Interface
{
    public interface ITokenService
    {
        JwtSecurityToken CreateToken(User user);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
