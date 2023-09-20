using System;
using System.Globalization;

namespace NastedLoop
{
    class Program
    {
        static void Main()
        {
            string[] names = new string[3] { "Habibor Rahaman", "Rifat", "Abdur Rahman" };

            int word = 0;
            int character = 0;

            foreach(string name in names)
            {
                word++;
                foreach (char data in name)
                {
                   character++;
                }
            }
            Console.WriteLine(word);
            Console.WriteLine(character);

            //adding two array same index element and sum strore same index
            int[] marks = new int[5] { 23, 45, 67, 54, 23 };
            int[] marks2 = new int[5] { 56, 45, 34, 23, 45 };
            int[] result = new int[5];

            for(int i = 0; i < marks.Length; i++)
            {
                result[i] = marks[i] + marks2[i];
            }

            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();

            //adding two array same index element and sum strore same index
            string[,] userName = new string[2, 3] {
                {"habibor", "abdur", "foez"},
                {"rahaman", "rahaman", "ahmed"}
            };

            int numberWord = 0;
            int numberCharacter = 0;

            for(int i = 0; i < userName.GetLength(0); i++)
            {
                for(int j = 0; j < userName.GetLength(1); j++)
                {
                    Console.WriteLine(userName[i, j]);
                    numberWord++;
                    for(int c = 0; c < userName[i, j].Length; c++)
                    {
                        numberCharacter++;
                    }
                }
            }
            Console.WriteLine(numberWord);
            Console.WriteLine(numberCharacter);
        }
    }
}