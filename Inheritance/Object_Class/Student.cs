using Inheritance.Abstruct_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Object_Class
{
    public class Student : Person
    {
        public string Type { get; set; }
        public bool IsReguler { get; set; }

        public Student(string id, string name, string birthday, string email, string phone, string address, string type, bool isReguler) 
        { 
            this.Id = SetPrifix(id);
            this.Name = name;
            this.BirthDay = birthday;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Type = type;
            this.IsReguler = isReguler;
        }

        private string SetPrifix(string id)
        {
            return this.Id = "ST-" + id;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Birthday: " + this.BirthDay);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Phone: " + this.Phone);
            Console.WriteLine("Address: " + this.Address);
            Console.WriteLine("Type: " + this.Type);
            Console.WriteLine("IsReguler: " + this.IsReguler);
        }

    }
}
