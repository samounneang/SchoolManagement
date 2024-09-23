using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Ensure to hash and salt in real applications
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public string CreateAt { get; set; }
        public string UpdateAt { get; set; }
    }
}
