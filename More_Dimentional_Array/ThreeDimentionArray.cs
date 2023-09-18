using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Dimentional_Array
{
    internal class ThreeDimentionArray
    {
        public void Hello()
        {
            int[, ,] result = new int[4, 4, 4]
            {
                {
                    { 12, 23, 38, 45 },
                    { 51, 62, 73, 85 },
                    { 92, 10, 11, 12 },
                    { 13, 14, 15, 16 }
                },

                {
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 },
                    { 25, 26, 27, 28 },
                    { 29, 30, 31, 32 }
                },

                {
                    { 33, 34, 35, 36 },
                    { 37, 38, 39, 40 },
                    { 41, 42, 43, 44 },
                    { 45, 46, 47, 48 }
                },

                {
                    { 49, 50, 51, 52 },
                    { 53, 54, 55, 56 },
                    { 57, 58, 59, 60 },
                    { 61, 62, 63, 64 }
                }
            };
            
            for(int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    for(int k = 0; k < result.GetLength(2); k++)
                    {
                        Console.Write(result[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
