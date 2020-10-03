using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientImg { get; set; }
        public string CDesc { get; set; }
        public string Job { get; set; }
        public bool IsActive { get; set; }
    }
}
