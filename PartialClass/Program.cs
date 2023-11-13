using PartialClass.Classes;
using System;

namespace PartialClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Programmer...");
            Person person = new Person("Habibr Rahaman", "habibor.rahaman1010@gmail.com");
            person.HelloWorld();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Email);
        }
    }
}