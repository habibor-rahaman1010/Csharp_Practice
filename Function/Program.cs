using System;

namespace Function
{
    class Program
    {
        //arraty element and character count this function....
        public static (int, int) ElementCount(string[] elements)
        {
            int ele = 0;
            int character = 0;
            foreach(string element in elements)
            {
                ele++;
                for(int i = 0; i < element.Length; i++)
                {
                    character++;
                }
            }
            return(ele, character);
        }
        public static void ShowSubject(string[] subjects)
        {   
            Array.Sort(subjects);  
            for(int i = 0; i < subjects.Length; i++)
            {
                Console.Write(subjects[i] + " ");
            }
            Console.WriteLine();

            (int, int) data = ElementCount(subjects);

            Console.WriteLine($"Number of elements: {data.Item1}");
            Console.WriteLine($"Number of character: {data.Item2}");
        }
        static void Main(string[] args)
        {
            string[] subjects = new string[5] { "C++", "CSharp", "Database", "OOP IN C#", "Operating System" };

            //if we don't use static keyword before ShowSubject methods then this process will work done....
           /*Program obj = new Program();
            obj.ShowSubject(subjects);*/

            // otherwise if we use static keyword before ShowSubject methods then this process will work done....
            ShowSubject(subjects);
        }
    }
}
