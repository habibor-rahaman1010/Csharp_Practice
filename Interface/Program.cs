using Interface.Classes;
using Interface.Interfaces;
using System;

namespace InterfaePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello programmer");
            
            Internet4G internet4G = new Internet4G();
            Internet5G internet5G = new Internet5G();

            Laptop laptop = new Laptop(internet5G);
            laptop.BrowseWebsite();
        }
    }
}
