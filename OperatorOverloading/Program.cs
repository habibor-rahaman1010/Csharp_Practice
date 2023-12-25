using OperatorOverloading.Structures;
using System;

namespace OperatoeOverloading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(3, 7);
            Fraction fraction2 = new Fraction(2, 9);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result);

            StringConcat s = new StringConcat("hello", "programmer");
            StringConcat s2 = new StringConcat("Developer", "Crizy");
            StringConcat result2 = s + s2;
            Console.WriteLine(result2);
        }
    }
}
