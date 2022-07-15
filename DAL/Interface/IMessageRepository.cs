using DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IMessageRepository
    {
        Task<PagedList<MessageDTO>> GetMessageForUser();
        Task<IEnumerable<MessageDTO>> GetMessageThread(int currentUserId, int recipientUserId);
    }
}
