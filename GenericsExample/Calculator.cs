using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Calculator<T> where T : INumber<T>
    {
        public T number1 { get; set; }
        public T number2 { get; set; }

        public Calculator(T num1, T num2) { 
            number1 = num1;
            number2 = num2;
        }
        public T Sum()
        {
            return number1 + number2;
        }
    }
}
