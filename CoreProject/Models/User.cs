using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserImg { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}
