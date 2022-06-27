using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserLike
    {
        public User CurrentUser { get; set; }
        public int CurrentUserId { get; set; }
        public User LikedUser { get; set; }
        public int LikedUserId { get; set; }
    }
}
