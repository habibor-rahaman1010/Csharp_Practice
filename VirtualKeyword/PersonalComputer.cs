using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    public class PersonalComputer : Computer
    {
        public string ComputerOwner {  get; set; }
        public int Price { get; set; }

        public sealed override string Start()  // uses of sealed we are not override this method, when who are inherit this class.
        {
            return "Personal computer starting...";
        }
        public void IsUpdateable()
        {
            Console.WriteLine($"{Start()} and is updatable.");
        }
    }
}
