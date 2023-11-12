using Abstruct_Class.Abstruct_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Class.Classes
{
    public class Buss : Vehicle
    {
        public string EngineType { get; set; }
        public int MaxSpeed { get; set; }
        public int Millage { get; set; }
        public string Transportation { get; set; }
        public Buss() { }
        public Buss(string model, string company, string color, string carType, string engineType, int maxSpeed, int millage, string transportation)
        {
            this.Model = model;
            this.Company = company;
            this.Color = color;
            this.CarType = carType;
            this.EngineType = engineType;
            this.MaxSpeed = maxSpeed;
            this.Millage = millage;
            this.Transportation = transportation;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Comapny: {this.Company}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"CarType: {this.CarType}");
            Console.WriteLine($"EnginType: {this.EngineType}");
            Console.WriteLine($"MaxSpeed: {this.MaxSpeed}");
            Console.WriteLine($"Millage: {this.Millage}");
            Console.WriteLine($"Transportation: {this.Transportation}");
        }

        public override void LoadFuel()
        {
            Console.WriteLine("Loaded Diggle in this Buss");
        }
    }
}