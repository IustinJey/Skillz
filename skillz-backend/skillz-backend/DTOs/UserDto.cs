using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skillz_backend.DTOs
{
    public class UserDto
    {
        
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Token { get; set; }

    }
}