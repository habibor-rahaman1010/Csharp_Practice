using System;
using ObjectOrientedProgramming.Vechile;
using ObjectOrientedProgramming.Car;

namespace ObjectOrientedProgramming
{
    class Program
    {   
        public string MakeSound()
        {
            return "Your are good programmer";
        }

        public static void SayHello()
        { 
            Console.WriteLine("Hello Programmer");
        }
        static void Main(string[] args)
        {
            Program.SayHello();
            Program p = new Program();
            Console.WriteLine(p.MakeSound());
            
            //intance of vehicle
            Cars toyota = new Cars();
            Cars.StartVehicle();

            Cars toyota2 = new Cars(781238, "Toyota Primio", "Toyota", "Red", 130, "Privet Car", "Petrol");
            toyota2.VehicleInfo();
        }
    }
}
