using System;

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
        }
    }
}