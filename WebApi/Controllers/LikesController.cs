using DAL.Entities;
using DAL.Extentions;
using DAL.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize]
    public class LikesController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly ILikesRepository _likesRepository;

        public LikesController(IUserRepository userRepository, ILikesRepository likesRepository)
        {
            _userRepository = userRepository;
            _likesRepository = likesRepository;
        }

        [HttpPost("{email}")]
        public async Task<ActionResult> AddLikeByEmail(string email)
        {
            var userId = int.Parse(User.GetId());
            var likedUser = await _userRepository.GetUserByEmail(email);
            if (likedUser == null) return NotFound();

            var currentUser = await _likesRepository.GetUserWithLikes(userId);
            if (currentUser.Email == email) return BadRequest("You cannot like yourself");

            var userLike = await _likesRepository.GetUserLike(userId, likedUser.Id);
            if (userLike != null) return BadRequest("You already like this user");

            userLike = new UserLike
            {
                CurrentUserId = userId,
                LikedUserId = likedUser.Id
            };

            currentUser.LikedUsers.Add(userLike);
            if(await _userRepository.SaveAll())
            {
                return Ok();
            }
            return BadRequest("Fail to like user");
        }

        [HttpGet]
        public async Task<ActionResult> GetUserLikes(string predicate)
        {
            var userId = int.Parse(User.GetId());
            var users = await _likesRepository.GetUserLikes(predicate, userId);
            return Ok(users);
        }
    }
}
