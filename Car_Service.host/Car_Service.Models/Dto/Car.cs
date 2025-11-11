using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.Models.Dto
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Model { get; set; } = string.Empty;
    }
}
