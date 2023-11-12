using Calculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class MyCalculator : ICalculator
    {
        public int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public int GetSubtruction(int num1, int num2)
        {
            return num1 - num2;
        }

        public double GetSubtruction(double num1, double num2)
        {
            return num1 - num2;
        }

        public int GetMultiplication(int num1, int num2)
        {
            return num2 * num2;
        }

        public double GetMultiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public int GetDivided(int num1, int num2)
        {
            return num1 / num2;
        }

        public double GetDivided(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
