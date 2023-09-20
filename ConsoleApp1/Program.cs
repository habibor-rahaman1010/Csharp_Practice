using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello Programmer!");

            string name1 = "Habibor";
            string name2 = "Rahaman";
            string fullName = name1 + " " + name2;
            Console.WriteLine(fullName);

            int x = 10;
            int y = 20;
            int ans = (x + y);
            Console.WriteLine($"Summation: {ans}");

            int d, g, h;
            d = 10;
            g = 13;
            h = 14;
            Console.WriteLine($"Sum is: {d + g + h}");
        }
    }
}
