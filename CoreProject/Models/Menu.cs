using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuItem { get; set; }
        public string MenuUrl { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }

    }
}
