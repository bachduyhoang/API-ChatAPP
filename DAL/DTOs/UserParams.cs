using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public enum OrderBy
    {
        LastActive,
        LastActiveDesc,
        Created,
        CreatedDesc,
        Age,
        AgeDesc
    }
    public enum SortOrder
    {
        Asc,
        Desc
    }
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public string? CurrentUserEmail { get; set; }
        public string? SearchUserName { get; set; }
        public string? Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 150;
        public OrderBy OrderBy { get; set; } = OrderBy.LastActive;
    }
}
