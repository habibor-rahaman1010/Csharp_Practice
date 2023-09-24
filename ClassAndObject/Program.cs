using System;
using System.Collections;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] habib = new Person[5]
            {
                new Person(144369, "Habibor Rahaman", "habibor.rahaman1010@gmail.com", 12000),
                new Person(287236, "Afsana Akter", "afsanaakter12@gmail.com", 18000),
                new Person(478233, "Abdur Rahaman", "abdur.rahaman10@gmail.com", 22000),
                new Person(172873, "Rifat Ahmed", "refat.ahmed2334e@gmail.com", 8000),
                new Person(298398, "Tamim Sahriar", "tamimsahriar@gmail.com", 14000)
            };
            
            for(int i = 0; i < habib.Length; i++)
            {
                Console.WriteLine($"Id: {habib[i].Id}");
                Console.WriteLine($"Name: {habib[i].Name}");
                Console.WriteLine($"Email: {habib[i].Email}");
                Console.WriteLine($"Blance: {habib[i].Balnce}");
                Console.WriteLine();
            }

            //Explore list and ArrayList in c# language....
            ArrayList hb = new ArrayList() {"Allen", 19, 30};
            hb.Add("hello");
            hb.Add(123);
            Console.WriteLine(hb[4]);

            List<int> hn = new List<int>() {12, 34, 56, 67};
            hn.Add(100);
            hn[1] = 500;
            Console.WriteLine(hn[4]);
            Console.WriteLine(hn[1]);
        }
    }
}
