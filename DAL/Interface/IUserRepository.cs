using DAL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByEmail(string email);
        Task<IEnumerable<User>> GetUsersAndPhoto();
        Task<PagedList<MemberDTO>> GetUsers(UserParams userParams);
    }
}
