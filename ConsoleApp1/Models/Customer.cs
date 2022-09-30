using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public ICollection<Order> Orders { get; set; } = null!; 



    }
}
