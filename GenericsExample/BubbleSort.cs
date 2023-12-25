using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class BubbleSort<T> where T : INumber<T>
    {
        public T[] Sort(T[] numbers)
        {
            bool flag = true;
            T temp;
            int numLength = numbers.Length;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            return numbers;
        }
    }
}
