using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    internal class UserDto
    {
        public  int userID { get; set; }
        public  string name { get; set; }
        public  string lastname { get; set; }
        public  string phone { get; set; }
        public string email { get; set; }
        public  string username { get; set; }
        public string password { get; set; }
        public string  userPhoto { get; set; }
        public int position { get; set; }
    }
}
