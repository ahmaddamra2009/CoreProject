using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProDesc { get; set; }
        public string ProImg { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string MCountry { get; set; }
        public int MyProperty { get; set; }
        public string Status { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public bool IsActive { get; set; }

    }
}
