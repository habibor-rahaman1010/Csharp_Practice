using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStructure.Structures
{
    public struct Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email) {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public void printName()
        {
            Console.WriteLine($"Name: {this.Name}");
        }
    }
}
