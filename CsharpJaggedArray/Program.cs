using System;

namespace CsharpJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Dimentional Jagged array...
            int[] age = new int[5];  //first of all array initialize then set value by index of the array
            age[0] = 20;
            age[1] = 30;

            int[] number = new int[5] { 12, 45, 56, 43, 45 }; // array initialize and in the mean time value assign in the array
            number[0] = 30;
            number[1] = 90;
            Console.WriteLine(number[0]);

            //loop run on to an 1 dimeltional Jagged array
            for (int i = 0; i < number.GetLength(0); i++)
            {
                int item = number[i];
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");



            //second dimentional array...
            int[][] matrix = new int[2][]; //first of all 2 dimentional Jagged array initialize then set value by index of the array
            matrix[0] = new int[4];
            matrix[1] = new int[5];

            //in jagged array value assign...
            matrix[0][0] = 14;
            matrix[1][0] = 15;
            matrix[0][1] = 35;
            Console.WriteLine(matrix[0][1]);

            int[][] matrix2 = new int[3][]  // 2 dimentional Jagged array initialize and in the mean time value assign in the array
            {
                new int[3] { 23, 34, 45},
                new int[5] { 50, 60, 67, 45, 78 },
                new int[3] { 100, 41, 101 }
            };

            //loop run on to an 2 dimeltional array
            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    int item = matrix2[i][j];
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            //second dimentional array...
            int[][][] matrix3 = new int[2][][]; //first of all 3 dimentional array initialize then set value by index of the array
            matrix3[0] = new int[2][];
            matrix3[0][0] = new int[4];
            matrix3[0][1] = new int[5];

            matrix3[1] = new int[2][];
            matrix3[1][0] = new int[5];
            matrix3[1][1] = new int[6];

            //in jagged array value assign...
            matrix3[0][0][0] = 34;
            matrix3[0][0][1] = 12;
            matrix3[0][1][0] = 84;
            matrix3[1][0][0] = 34;
            matrix3[1][1][5] = 94;

            Console.WriteLine(matrix3[1][1][5]);
            Console.WriteLine(matrix3[0][1][0]);


            int[][][] matrix4 = new int[3][][]  // 3 dimentional Jagged array initialize and in the mean time value assign in the array
            {
                new int [3][]{
                    new int[3] { 23, 34, 45},
                    new int[4] { 50, 60, 67, 67 },
                    new int[5] { 100, 41, 101, 56, 54}
                },

                new int[4][]{
                    new int[3] { 23, 34, 45},
                    new int[5] { 50, 60, 67, 89, 91 },
                    new int[2] { 100, 41},
                    new int[6] { 100, 41, 101, 12, 34, 56}
                },

                new int[3][]{
                    new int[5] { 23, 34, 45, 81, 30},
                    new int[4] { 50, 60, 67, 67 },
                    new int[3] { 100, 41, 101}
                }
            };
            Console.WriteLine(matrix4[2][2][2] + "\n");

            //loop run on to an 3 dimeltional array...
            for (int i = 0; i < matrix4.Length; i++)
            {
                for (int j = 0; j < matrix4[i].Length; j++)
                {
                    for (int k = 0; k < matrix4[i][j].Length; k++)
                    {
                        int item = matrix4[i][j][k];
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
