using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public class TokenResponseDTO
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}
