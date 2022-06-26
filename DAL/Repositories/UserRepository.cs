using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL.DTOs;
using DAL.EF;
using DAL.Entities;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IMapper _mapper;

        public UserRepository(ChatContext context, IMapper mapper): base(context)
        {
            _mapper = mapper;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.Include(x => x.Photos).SingleOrDefaultAsync(x => x.Email == email);
        }

        public async Task<PagedList<MemberDTO>> GetUsers(UserParams userParams)
        {
            var query = _context.Users.AsQueryable();

            query = query.Where(u => u.Email != userParams.CurrentUserEmail);
            query = query.Where(u => u.Gender == userParams.Gender);

            var minDob = DateTime.Today.AddYears(-userParams.MaxAge - 1);
            var maxDob = DateTime.Today.AddYears(-userParams.MinAge);

            query = query.Where(u => u.DateOfBirth >= minDob && u.DateOfBirth <= maxDob);
            query = userParams.OrderBy switch
            {
                OrderBy.Created => query.OrderByDescending(x => x.Created),
                OrderBy.Age => query.OrderByDescending(x => x.DateOfBirth),
                _ => query.OrderByDescending(u => u.LastActive),
            };

            return await PagedList<MemberDTO>.CreateAsync(query.ProjectTo<MemberDTO>(_mapper.ConfigurationProvider)
                .AsNoTracking(), userParams.PageNumber, userParams.PageSize);
        }

        public async Task<IEnumerable<User>> GetUsersAndPhoto()
        {
            return await _context.Users.Include(x => x.Photos).ToListAsync();
        }
    }
}
