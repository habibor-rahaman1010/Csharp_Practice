using Inheritance.Abstruct_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Object_Class
{
    public class Teacher : Person
    {
        public string Type { get; set; }
        public bool IsReguler { get; set; }
        public int Salary { get; set; }
        public List<string> TackCourse { get; set; }


        public Teacher(string id, string name, string birthday, string email, string phone, string address, string type, bool isReguler, int salary, List<string> tackCourse)
        {
            this.Id = SetPrifix(id);
            this.Name = name;
            this.BirthDay = birthday;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Type = type;
            this.IsReguler = isReguler;
            this.Salary = salary;
            this.TackCourse = tackCourse;
        }

        private string SetPrifix(string id)
        {
            return this.Id = "TE-" + id;
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
            Console.WriteLine("Salary: " + this.Salary);
            Console.Write("Tack Course: ");

            //This is code for comma separeting in TackCourse list
            int i = 0;
            foreach(string course in this.TackCourse)
            {
                Console.Write(course);
                if (i < this.TackCourse.Count - 1)
                {
                    Console.Write(" | ");
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
