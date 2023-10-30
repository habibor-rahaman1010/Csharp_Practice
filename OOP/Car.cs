using ObjectOrientedProgramming.Vechile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Car
{
    public class Cars : Vehicle
    {
        public string Type { get; set; }
        public string EnginType { get; set; }

        public Cars() { }

        public Cars(int serialNo, string name, string company, string color, int speed, string type, string enginType)
        {
            this.SerialNo = serialNo;
            this.Name = name;
            this.Company = company;
            this.Color = color;
            this.Speed = speed;
            this.Type = type;
            this.EnginType = enginType;
        }
        public override void VehicleInfo()
        {
            Console.WriteLine($"Serial No: {this.SerialNo}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Company: {this.Company}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Speed: {this.Speed}");
            Console.WriteLine("Type: " + this.Type);
            Console.WriteLine("Engin Type: " +  this.EnginType);
        }
    }
}

