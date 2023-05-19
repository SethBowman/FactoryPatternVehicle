using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                default:
                  return new Car();                    
            }
        }
    }

}
