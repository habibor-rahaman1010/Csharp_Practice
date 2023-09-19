using System;

namespace ArrayLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5] { "Allen", "Musfiq", "Asraf", "Habibor Rahaman", "Rifat"};
            Array.Sort(friends);
            for(int i = 0; i < friends.Length; i++)
            {
                string name = friends[i];
                Console.Write(name + " ");
            }
            Console.WriteLine();    

            //array all element sum in c# program....
            int[] numbers = new int[6] { 34, 56, 67, 54, 23, 45 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Total sum is: {sum}");

            //find max value in array in c# program.....
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Max value is: {max}");

            //find min value in array in c# program.....
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Min value is: {min}");
        }
    }
}
