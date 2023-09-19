using System;

namespace ForeachLoop
{
    // Define your custom class MyClass
    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public MyClass()
        {
            // Default constructor
        }

        public MyClass(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an array of custom objects (MyClass)
            MyClass[] obj2 = new MyClass[] { new MyClass(), new MyClass() };

            // And initializing to value in this array
            obj2[0].Id = 144369;
            obj2[0].Name = "Habibor Rahaman";
            obj2[0].Email = "habibor.rahaman1010@gmail.com";

            obj2[1].Id = 287331;
            obj2[1].Name = "Abdur Rahaman";
            obj2[1].Email = "abdurrahama12@gmail.com";

            // Accessing and using the objects in the array
            Console.WriteLine("Array of MyClass objects:");
            foreach (MyClass obj in obj2)
            {
                Console.WriteLine($"Id: {obj.Id}, Name: {obj.Name},  Email: {obj.Email}");
            }
            Console.WriteLine();


            // Declaring and initializing an array of custom objects (MyClass)
            MyClass[] objects = new MyClass[]
            {
                new MyClass(1, "Alice", "alice@gmail.com"),
                new MyClass(2, "Bob", "bob@gmail.com")
            };

            // Accessing and using the objects in the array
            Console.WriteLine("Array of MyClass objects:");
            foreach (MyClass obj in objects)
            {
                Console.WriteLine($"Id: {obj.Id}, Name: {obj.Name}, Email: {obj.Email}");
            }
        }
    }
}
