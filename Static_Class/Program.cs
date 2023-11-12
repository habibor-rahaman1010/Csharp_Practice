using System;
using Static_Class.static_classes;

namespace Static_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomNumberGenerator.Generate());
            }
        }
    }
}