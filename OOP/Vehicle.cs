using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Vechile
{
    public abstract class Vehicle
    {
        public int SerialNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company {  get; set; } = string.Empty;
        public string Color {  get; set; } = string.Empty;
        public int Speed { get; set; }

        public abstract void VehicleInfo();

        public static void StartVehicle()
        {
            Console.WriteLine("Vehicle Starting");
        }
    }
}
