using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderUsername { get; set; }
        public User Sender { get; set; }
        public int RecipentId { get; set; }
        public string RecipientUsername { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }
        public DateTime DateRead { get; set; }
        public DateTime dateTime { get; set; }=DateTime.Now;
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
    }
}
