using BaseConstructor.Classes;
using System;

namespace BaseConstructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person habib = new Student("habib", "habib@gmail.com", "dhaka", "Dhaka", "Bangladesh", "Islam", "02309234", "144369", "NUB");
            habib.GetPersionInfo();
        }
    }
}
