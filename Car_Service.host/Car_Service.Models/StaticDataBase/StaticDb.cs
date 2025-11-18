using Car_Service.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.Models.StaticDataBase
{
    public static class StaticDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
 {
     new Car() { Id=1, Model="BMW", Year=2010 },
     new Car() { Id=2, Model="Audi", Year=2012 },
     new Car() { Id=3, Model="Mercedes", Year=2015 },
 };
        public static List<Customer> Customers =
            new List<Customer>()
            {
                new Customer()
                {
                    Id= Guid.NewGuid(),
                    Name = "John Doe",
                    Email = "jd@xxx.com"
                },
                new Customer()
                {
                    Id= Guid.NewGuid(),
                    Name = "Stamat Genov",
                    Email = "sg@xxx.com"
                }
            };
    }
}
