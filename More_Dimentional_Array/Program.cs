using System;
using Three_Dimentional_Array;

namespace More_Dimentional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[,] { 
                { 13, 22, 32 },
                { 23, 45, 23 },
                { 24, 55, 77 }
            };

            for(int i = 0; i < marks.GetLength(0); i++) //marks.GetLength(0) gives you the number of rows.
            {
                for(int j = 0; j < marks.GetLength(1); j++) //marks.GetLength(1) gives you the number of columns.
                {
                    Console.Write(marks[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Create a object and then print 3 dimentional array in c# program....
            ThreeDimentionArray obj = new ThreeDimentionArray();
            obj.Hello();
        }
    }
}