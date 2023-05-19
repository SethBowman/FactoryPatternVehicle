using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Big Rig!");
        }
    }
}