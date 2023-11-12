using Constructor.Classes;
using Constructor.Interface;
using System;

namespace Contructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVheicle toyota = new Car("Habibor Rahaman", "Black", 20);
            
            Console.WriteLine($"Name: {toyota.Name}");
            Console.WriteLine($"Color: {toyota.Color}");
            Console.WriteLine($"Price: {toyota.Price}");
        }
    }
}