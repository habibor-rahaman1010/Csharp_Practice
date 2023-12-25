using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Structures
{
    public struct Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Fraction operator+ (Fraction a, Fraction b)
        {
            return new Fraction(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);
        }
        public override string ToString()
        {

            return $"""
                  {_numerator}
                -------
                  {_denominator}
                """;
        }
    }
}
