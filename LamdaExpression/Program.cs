using System;

namespace LamdaExpression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Lamda funtion
            int Sum(int x, int y) => (x + y);
            int s = Sum(10, 23);
            Console.WriteLine(s);

            //anonymous function and return value
            Func<int, int, int> sum = (a, b) => a + b;  
            int a = sum(40, 23);
            Console.WriteLine(a);
            
            //anonymous function and no return value
            Action<int, int> sub = (a, b) => Console.WriteLine(a - b);
            sub(12, 4);
        }
    }
}
