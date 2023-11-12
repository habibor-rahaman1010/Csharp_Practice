using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor.Classes
{
    public class Student : Person
    {
        string StudentId { get; set; }
        string UniversityName { get; set; }

        public Student(string name, string email, string address, string city, string country, string religion, string phone, string id, string versityName) : base(name, email, address, city, country, religion, phone) {
            this.StudentId = id;
            this.UniversityName = versityName;
        }

        public override void GetPersionInfo()
        {
            Console.WriteLine($"Id: {this.StudentId}");
            Console.WriteLine($"Versity Name: {this.UniversityName}");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Address: {this.Address}");
            Console.WriteLine($"City: {this.City}");
            Console.WriteLine($"Country: {this.Country}");
            Console.WriteLine($"Religion: {this.Religion}");
            Console.WriteLine($"Phone: {this.Phone}");
        }
    }
}
