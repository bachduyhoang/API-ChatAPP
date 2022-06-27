using DAL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int currentUserId, int likedUserId);
        Task<User> GetUserWithLikes(int currentUserId);
        Task<IEnumerable<LikeDTO>> GetUserLikes(string predicate, int currentUserId);
    }
}
