using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedData.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Telephone { get; set; }
        public int Age { get; set; }
        public decimal  SpendAverage { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime JoinDate{ get; set; }
    }
}
