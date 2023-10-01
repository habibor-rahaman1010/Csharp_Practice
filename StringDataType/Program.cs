using System;
using System.ComponentModel;

namespace StringDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Habibor Rahaman";
            string location = "Mohammodput - Dhaka";
            Console.WriteLine("Hello {0}, you are from {1}", name, location);
            Console.WriteLine("Hello {1}, you are from {0}", location, name);
            Console.WriteLine($"Hello {name}, you are from {location}");

            //string line = new string(Console.ReadLine());
            string line2 = Console.ReadLine();
            int x = Console.Read();
            int y = Console.Read();

            int data = Console.Read();
            //Console.WriteLine((char)data);

            ConsoleKeyInfo data2 = Console.ReadKey();
            int z = Console.Read();
            int v = Console.Read();

            //Console.WriteLine();
            //Console.WriteLine(data2.Key);
            //Console.WriteLine(data2.KeyChar);

            int[] nums = new int[3];
            string inputLine = Console.ReadLine();
            string[] partsLine = inputLine.Split(',', ' ');

            nums[0] = int.Parse(partsLine[0]);
            nums[1] = int.Parse(partsLine[1]);
            nums[2] = int.Parse(partsLine[2]);
        }
    }
}
