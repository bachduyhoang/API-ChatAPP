using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extentions
{
    public static class DateTimeExtentions
    {
        public static int CalculateAge(this DateTime dob)
        {
            if(dob == null) return 0;
            var age = DateTime.Today.Year - dob.Year;
            if(dob.Date > DateTime.Today.AddYears(-age)) age-- ;
            return  age ;
        }
    }
}
