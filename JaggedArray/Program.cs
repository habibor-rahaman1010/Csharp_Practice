using System;
using System.Runtime.Versioning;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] result = new int[5][]; //declear a jagged array

            //jagged array element itself an array
            result[0] = new int[5];
            result[1] = new int[3];
            result[2] = new int[6];
            result[3] = new int[6];
            result[4] = new int[6];

            //assign value in jagged array continue to every dimention
            result[0][0] = 28;
            result[0][1] = 23;
            result[0][3] = 43;


            int[][] marks = new int[5][]; //declear a jagged array

            //assign value in jagged array 
            marks[0] = new int[5] { 12, 23, 26, 34, 56 };
            marks[1] = new int[3] { 23, 45, 56 };
            marks[2] = new int[6] { 54, 67, 54, 23, 56, 78 };
            marks[3] = new int[6] { 51, 68, 55, 24, 52, 71 };
            marks[4] = new int[6] { 14, 27, 34, 43, 26, 98 };

            for(int i = 0; i < marks.Length; i++)
            {
                for(int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //another way to declear jagged array in csharp language....
            string[][] friends = new string[][]
            {
                new string[] {"Habib", "Allen", "Sufiya", "Saad"},
                new string[] {"Tarek", "Shawon", "Iftekhar", "Matlab"},
                new string[] {"Rifat", "Habib", "Arafat"},
                new string[] {"Programmer", "Developer", "Engineer"}
            };

            for (int i = 0; i < friends.Length; i++)
            {
                for(int k = 0; k < friends[i].Length; k++)
                {
                    Console.Write(friends[i][k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //another way to deacler jagged array in csharp....
            string[][] technology =
            {
                new string[] {"Csharp", "Java", "C++", "Pyrhon"},
                new string[] {"JavaScript", "php", "TypeScript"},
                new string[] {"Database", "Operating System", "Process Log", "Over Clock", "System Dessign"},
                new string[] {"MySQL", "MSSQL", "SQLlite", "PostgreSQL"}
            };

            for(int n = 0; n < technology.Length; n++)
            {
                for(int m = 0; m < technology[n].Length; m++)
                {
                    Console.Write(technology[n][m] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // jagged array and multi daimention array mixed in csharp....
            int[][,] digite = new int[3][,]
            {
                new int[,] { { 12, 34, 45}, { 34, 32, 56} },
                new int[,] { { 12, 34, 45}, { 34, 32, 56} },
                new int[,] { { 12, 34, 45}, { 34, 32, 56} },
            };

            for(int i = 0; i < digite.Length; i++)
            {
                for(int j = 0; j < digite[i].GetLength(0); j++)
                {
                    for(int k = 0; k < digite[i].GetLength(1); k++)
                    {
                        Console.Write(digite[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            // jagged array and multi daimention array mixed in csharp....
            int[][,] student_marks = new int[][,]
            {
                new int[,] { { 12, 34, 45}, { 34, 32, 56}, { 34, 32, 56} },
                new int[,] { { 12, 34, 45}, { 34, 32, 56}, { 34, 32, 56} },
                new int[,] { { 12, 34, 45}, { 34, 32, 56}, { 34, 32, 56} },
                new int[,] { { 12, 34, 45}, { 34, 32, 56}, { 34, 32, 56} },
            };

            for (int i = 0; i < student_marks.Length; i++)
            {
                for (int j = 0; j < student_marks[i].GetLength(0); j++)
                {
                    for (int k = 0; k < student_marks[i].GetLength(1); k++)
                    {
                        Console.Write(student_marks[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
