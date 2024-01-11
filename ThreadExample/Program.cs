using System;

namespace ThreadExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(() => PrintEvent(1000));
            Thread t2 = new Thread(() => PrintOdd(1000));

            void PrintEvent(int count)
            {
                for(int i = 0; i < count; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            void PrintOdd(int count)
            {
                for (int i = 1; i < count; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            t1.Start();
            t2.Start();
        }
    }
}