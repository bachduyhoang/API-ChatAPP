using AutoMapper;
using DAL.DTOs;
using DAL.EF;
using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        private readonly IMapper _mapper;

        public MessageRepository(ChatContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public Task<PagedList<MessageDTO>> GetMessageForUser()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MessageDTO>> GetMessageThread(int currentUserId, int recipientUserId)
        {
            throw new NotImplementedException();
        }
    }
}
