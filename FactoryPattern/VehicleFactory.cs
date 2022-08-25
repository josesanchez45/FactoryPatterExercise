using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehichle(int choice)
        {
            switch (choice)
            {
                case 4:
                    return new Car();

                case 2:
                    return new Motorcycle();

                default:
                    return new Car();
            }
                

        }
    }
}
