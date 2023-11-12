using Abstruct_Class.Abstruct_classes;
using Abstruct_Class.Classes;
using System;

namespace Abstruct_Class
{
    public class Program
    {
        public static void Main()
        {
            SportsCar car = new SportsCar("Nissan GTR", "Nissan", "Black", "Sports", "Ged Engine", 280, 12);
            car.GetInfo();
            car.LoadFuel();
            Console.WriteLine();

            Buss buss = new Buss("GreenLine", "Hino", "Silver", "Luxsary Buss", "Disggle", 280, 25, "Bussines Class");
            buss.GetInfo();
            buss.LoadFuel();
        }
    }
}