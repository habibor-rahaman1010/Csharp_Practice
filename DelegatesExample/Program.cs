using System;

namespace DelegatesExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Delegates use here...
            Delegates<int> myDelegates = new Delegates<int>();
            myDelegates.MySummation(30, 23, doSum);

            int doSum(int x, int y)
            {
                return x + y; 
            }

            Delegates<Person> myDelegates2 = new Delegates<Person>();
            List<Person> people = new List<Person>()
            {
                new Person{Id = 1, Age = 24, Name = "Habibor Rahaman"},
                new Person{Id = 2, Age = 14, Name = "Tarmim Ahamed"},
                new Person{Id = 3, Age = 34, Name = "Falack Rahaman"},
                new Person{Id = 4, Age = 12, Name = "Falack Rahaman"},
            };

            List<Person>? m = myDelegates2.GetLargeAge(people, FindeLargeAge);

            Console.Write("Age Sort: ");
            foreach (Person person in people)
            {
                Console.Write($"{person.Age} ");
            }
            Console.WriteLine();

            bool FindeLargeAge(Person a, Person b)
            {
                return a.Age > b.Age;
            }

            //Mordern Delegates use here...
            Func<int, int, int> sum = Sum;
            Action<int, int> sub = Sub;

            int Sum(int x, int y)
            {
                return x + y;
            }

            void Sub(int x, int y)
            {
                Console.WriteLine($"Sub is: {x - y}");
            }

            void doMath(Func<int, int, int> summation, Action<int, int> subtraction)
            {
                int result = summation(34, 23);
                Console.WriteLine($"Sum is: {result}");
                subtraction(20, 10);
            }

            doMath(sum, sub);
        }
    }
}
