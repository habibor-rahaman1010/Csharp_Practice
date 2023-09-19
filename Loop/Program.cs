using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is my for loop in csharp....
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // This is my for loop in csharp....
            int z = 0;
            for (; z < 10;)
            {
                Console.WriteLine(z);
                z++;
            }

            //wile loop in c# program....
            int n = 0;  
            while(n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }

            //do while loop in c# program....
            int k = 0;
            do
            {
                Console.WriteLine("Hello Programmer");
                k++;
            } while (k < 10);

            // This is my for loop in csharp....
            int x = 0;
            for (; ; )
            {
                if (x < 10)
                {
                    Console.WriteLine(x);
                    x++;
                }
            }
        }
    }
}
