using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a: ");
            string? a = Console.ReadLine();
            int x = int.Parse(a);

            Console.WriteLine("Enter the value of b: ");
            string? b = Console.ReadLine();
            int y = int.Parse(b);

            int z = x + y;
            Console.WriteLine(z);

            Console.WriteLine(a.GetType());
            Console.WriteLine(x.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(y.GetType());
        }
    }
}
