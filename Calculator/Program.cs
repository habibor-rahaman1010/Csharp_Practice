using Calculator.Classes;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator calculator = new MyCalculator();
            int result = calculator.GetSum(34, 45);
            Console.WriteLine(result);
        }
    }
}
