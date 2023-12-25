using PracticeStructure.Structures;
using System;
namespace PracticeStucture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello programmer");

            Person person = new Person("Habibor Rahaman", 23, "habibor.rahaman1010@gmail.com");
            Person person2 = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Email);
            person2.printName();
            person.printName();
        }
    }
}
