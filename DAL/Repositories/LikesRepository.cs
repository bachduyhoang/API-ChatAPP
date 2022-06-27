using DAL.DTOs;
using DAL.EF;
using DAL.Entities;
using DAL.Extentions;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LikesRepository : ILikesRepository
    {
        private readonly ChatContext _context;

        public LikesRepository(ChatContext context)
        {
            _context = context;
        }

        public async Task<UserLike> GetUserLike(int currentUserId, int likedUserId)
        {
            return await _context.Likes.FindAsync(currentUserId, likedUserId);
        }

        public async Task<IEnumerable<LikeDTO>> GetUserLikes(string predicate, int currentUserId)
        {
            var users = _context.Users.OrderBy(u =>u.FullName).AsQueryable();
            var likes = _context.Likes.AsQueryable();

            if(predicate == "liked")
            {
                likes = likes.Where(like => like.CurrentUserId == currentUserId);
                users = likes.Select(like => like.LikedUser);
            }

            if (predicate == "likedBy")
            {
                likes = likes.Where(like => like.LikedUserId == currentUserId);
                users = likes.Select(like => like.CurrentUser);
            }

            return await users.Select(user => new LikeDTO
            {
                FullName = user.FullName,
                Age = user.DateOfBirth.CalculateAge(),
                PhotoUrl = user.Photos.FirstOrDefault(p => p.IsMain).Url,
                City = user.City,
                Id = user.Id
            }).ToListAsync();
        }

        public async Task<User> GetUserWithLikes(int currentUserId)
        {
            return await _context.Users
                    .Include(x => x.LikedUsers)
                    .FirstOrDefaultAsync(x => x.Id == currentUserId);
        }
    }
}
