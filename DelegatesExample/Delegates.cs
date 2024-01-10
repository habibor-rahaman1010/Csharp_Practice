using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class Delegates<T>
    {
        public delegate int Sum(T x, T y);
        public delegate bool FindLargeAge(T a, T b);

        public void MySummation(T n, T m, Sum summation)
        {
            int result = summation(n, m);
            Console.WriteLine($"My Sum is: {result}");
        }

        public List<T>? GetLargeAge(List<T> person, FindLargeAge findLargeAge)
        {
            try
            {
                bool flags = true;
                T temp;
                for (int i = 0; i < person.Count - 1; i++)
                {
                    flags = false;
                    for (int j = 0; j < person.Count - 1; j++)
                    {
                        if (findLargeAge(person[j + 1], person[j]))
                        {
                            temp = person[j];
                            person[j] = person[j + 1];
                            person[j + 1] = temp;
                            flags = true;
                        }
                    }
                }
                return person;
            }
            catch (Exception error) 
            {
                Console.WriteLine(error.Message);
                return default(List<T>);
            }
        }
    }
}
