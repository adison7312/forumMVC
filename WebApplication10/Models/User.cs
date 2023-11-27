using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime LastTimeActive { get; set; }
        public int RoleID { get; set; }
        public string Status { get; set; }
        public string Language { get; set; }
        public string Skin { get; set; }
        public int Settings { get; set; }
    }
}
