using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LINQ.Extentions
{
    public static class Filter
    {
        public static List<Customer> GetAhmeds(List<Customer> list)
        {
            List<Customer> ahmds = new List<Customer>();
            foreach (var item in list)
            {
                if (item.Name.Contains("Ahmed"))
                {
                    ahmds.Add(item);
                }
            }
            return ahmds;
        }
    }
}
