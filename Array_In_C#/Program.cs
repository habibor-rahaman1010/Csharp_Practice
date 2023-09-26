using System;

namespace ArrayInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            //first dimentional array in csharp...
            int[] numbers = new int[5] { 12, 23, 34, 45, 56 };
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            //increse the size of the number array but delete all privious value when we new size of the array...
            numbers = new int[10];
            numbers[0] = 67;
            numbers[2] = 88;
            

            //second dimentional array in csharp...
            int[,] matrix = new int[3, 3]
            {
                { 23, 34, 44 },
                { 45, 56, 67 },
                { 78, 65, 34 }
            };
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //value rettive in the matrinx...
            Console.WriteLine(matrix[0, 0]);

            //increse the size of the number array but delete all privious value when we new size of the array...
            matrix = new int[5, 5];
            matrix[0, 0] = 12;
            matrix[0, 1] = 23;

            //value rettive in the matrinx...
            Console.WriteLine(matrix[0, 0]);

            //Third dimentional array in csharp program...
            int[,,] matrix2 = new int[2, 2, 2]
            {
                {
                    { 23, 34 },
                    { 34, 45 }
                },
                {
                    { 23, 34 },
                    { 34, 45 }
                }
            };
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for(int n = 0; n < matrix2.GetLength(2); n++)
                    {
                        Console.Write(matrix2[i, j, n] + " ");
                    }
                    Console.WriteLine();
                }
            }

            //value rettive in the matrinx...
            Console.WriteLine(matrix2[0, 0, 0]);
            Console.WriteLine(matrix2[1, 1, 1]);

            //increse the size of the number array but delete all privious value when we new size of the array...
            matrix2 = new int[3, 3, 3];
            matrix2[0, 0, 0] = 12;
            matrix2[0, 1, 2] = 23;

            //value rettive in the matrinx...
            Console.WriteLine(matrix2[0, 0, 0]);
            Console.WriteLine(matrix2[1, 1, 1]);
        }
    }
}