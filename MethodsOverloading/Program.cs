using System;

namespace MethodsOverloading
{
    class Program
    {   
        public static void SayHello()
        {
            Console.WriteLine("Hello Programmer!");
        }

        public static void SayHello(string grit)
        {
            Console.WriteLine("Hello Programmer! " + grit);
        }

        public static int AddNumber()
        {
            return 5 + 5;
        }

        public static int AddNumber(int x, int y) { 
            return x  + y;
        }

        public static int AddNumber(float x, float y)
        {
            return (int)(x + y);
        }

        public static double AddNumber(float x, float y, double z)
        {
            return (double)(x + y + z);
        }

        static void Main(string[] args) {
            //calling all methods here....
            SayHello();
            SayHello("How are you?");
            Console.WriteLine(AddNumber());
            Console.WriteLine(AddNumber(10, 20));
            Console.WriteLine(AddNumber(20.50f, 30.50f));
            Console.WriteLine(AddNumber(10.50f, 10.50f, 30.70));
        }
    }
}
