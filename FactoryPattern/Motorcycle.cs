using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.Write ("Building a new motorcycle!");
        }
    }
}
