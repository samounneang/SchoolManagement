using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    internal class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Ensure to hash and salt in real applications
        public string Role { get; set; }
    }
}
