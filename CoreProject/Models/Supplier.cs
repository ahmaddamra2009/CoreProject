using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string FbUrl { get; set; }
        public string TwUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string EmailUrl { get; set; }
        public bool IsActive { get; set; }

    }
}
