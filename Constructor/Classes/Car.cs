using Constructor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Classes
{
    public class Car : IVheicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Car() : this(string.Empty, string.Empty, 0){ 
            
        }

        public Car(int price) : this(string.Empty, string.Empty, price)
        {

        }

        public Car(string name, string color) : this(name, color, 0)
        {

        }

        public Car(string name, int price) : this(name, string.Empty, price)
        {

        }

        public Car(string name, string color, int price)
        {
            this.Name = name;
            this.Color = color;
            this.Price = price;
        }

        public void Move()
        {
            Console.WriteLine("Car is movig away right now!");
        }

        public void Start()
        {
            Console.WriteLine("Car is starting right know!");
        }
    }
}
