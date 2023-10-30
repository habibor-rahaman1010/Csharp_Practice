using Inheritance.Abstruct_Class;
using Inheritance.Object_Class;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Programmer");

            Person student = new Student("144369", "Habibor Rahaman", "05-03-1999", "habibor.rahaman1010@gmail.com", "01768280237", "Dhaka", "Student", true);
            student.GetInfo();
            Console.WriteLine();

            List<string> tackCourse = new List<string>() { "Data Structure", "OOP", "CSharp", "Design Pattern", "ASP.NET Core"};
            Teacher teacher = new Teacher("782373", "Jalal Uddin", "23-4-1980", "jalaluddin@gmail.com", "01729829312", "Mirpur-11", "Teacher", true, 220000, tackCourse);   
            teacher.GetInfo();
        }
    }
}