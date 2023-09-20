using System;

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
        }
    }
}
