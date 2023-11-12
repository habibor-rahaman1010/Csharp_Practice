using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interface
{
    internal interface ICalculator
    {
        int GetSum(int num1, int num2);
        double GetSum(double num1, double num2);

        int GetSubtruction(int num1, int num2);
        double GetSubtruction(double num1, double num2);

        int GetMultiplication(int num1, int num2);
        double GetMultiplication(double num1, double num2);

        int GetDivided(int num1, int num2);
        double GetDivided(double num1, double num2);
    }
}
