using System;

namespace DimentionalAndGaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Dimentional array...
            int[] age = new int[5];  //first of all array initialize then set value by index of the array
            age[0] = 20;
            age[1] = 30;

            int[] number = new int[5] { 12, 45, 56, 43, 45 }; // array initialize and in the mean time value assign in the array
            number[0] = 30;
            number[1] = 90;
            Console.WriteLine(number[0]);

            //loop run on to an 1 dimeltional array
            for(int i = 0; i < number.GetLength(0); i++)
            {
                int item = number[i];
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");



            //second dimentional array...
            int[,] matrix = new int[2, 2]; //first of all 2 dimentional array initialize then set value by index of the array
            matrix[0, 0] = 34;
            matrix[0, 1] = 50;
            matrix[1, 1] = 90;
            Console.WriteLine(matrix[0, 1]);

            int[,] matrix2 = new int[3, 3]  // 2 dimentional array initialize and in the mean time value assign in the array
            {
                { 23, 34, 45},
                { 50, 60, 67 },
                { 100, 41, 101}
            };

            //loop run on to an 2 dimeltional array
            for(int i = 0; i < matrix2.GetLength(0); i++)
            {
                for(int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int item = matrix2[i, j];
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            //second dimentional array...
            int[, ,] matrix3 = new int[2, 2, 2]; //first of all 3 dimentional array initialize then set value by index of the array
            matrix3[0, 0, 0] = 34;
            matrix3[0, 1, 1] = 50;
            matrix3[1, 1, 1] = 90;

            int[, ,] matrix4 = new int[3, 3, 3]  // 3 dimentional array initialize and in the mean time value assign in the array
            {
                {
                    { 23, 34, 45},
                    { 50, 60, 67 },
                    { 100, 41, 101}
                },
                {
                    { 23, 34, 45},
                    { 50, 60, 67 },
                    { 100, 41, 101}
                },
                {
                    { 23, 34, 45},
                    { 50, 60, 67 },
                    { 100, 41, 101}
                }
            };
            Console.WriteLine(matrix4[2, 2, 2] + "\n");

            //loop run on to an 3 dimeltional array...
            for(int i = 0; i < matrix4.GetLength(0); i++)
            {
                for(int j = 0; j < matrix4.GetLength(1); j++)
                {
                    for(int k = 0; k < matrix4.GetLength(2); k++)
                    {
                        int item = matrix4[i, j, k];
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}