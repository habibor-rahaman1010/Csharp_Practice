using System;

namespace StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello Programmer";
            for(int j = 0; j < text.Length; j++)
            {
                Console.WriteLine(text[j]); 
            }

            //string input from user
            string[] name = new string[5];
            for(int i = 0; i < name.Length; i++)
            {
                //name[i] = Console.ReadLine();
            }

            for(int i = 0; i < name.Length; i++)
            {
               // Console.WriteLine($"{name[i]} "); 
            }
        } 
    }
}
