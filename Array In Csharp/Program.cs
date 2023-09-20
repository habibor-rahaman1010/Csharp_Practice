using System;

namespace ArrayPractice
{
    class ArrayDataStructure
    {
        static void Main(string[] args)
        {
            //4 type way to create array...
            string[] name = { "Habibor Rahaman", "Wahid", "Tarek", "Shawon", "Rifat" };

            string[] cars;
            cars = new string[4] { "Toyota", "Voxwagen", "Nissan", "Mercidies"};

            string[] books = new string[] {"Operating system", "Database", "Network", "System Design"};

            int[] number = new int[5];
            number[0] = 18;
            number[1] = 10;
            number[2] = 20;
            number[3] = 30;
            number[4] = 50;

            //this is my for loop
            for (int i = 0; i < books.Length; i++)
            {
                string value = books[i];
                Console.WriteLine(value );
            }

            //this is my foreach loop
            foreach (var book in books)
            {
                Console.Write(book + " ");
            }
            Console.WriteLine();

            //this is my while loop use on array
            int n = 0;
            while (n < name.Length)
            {
                string value = name[n];
                Console.Write($"{value} ");
                n++;
            }
        }
    }
}
