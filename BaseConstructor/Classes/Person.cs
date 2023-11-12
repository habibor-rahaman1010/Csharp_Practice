using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor.Classes
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Religion { get; set; }
        public string Phone { get; set; }

        public Person() { }

        public Person(string name, string email, string address, string city, string country, string religion, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
            this.City = city;
            this.Country = country;
            this.Religion = religion;
            this.Phone = phone;
        }

        public virtual void GetPersionInfo() { }
        
        public void PersonWalk()
        {
            throw new NotImplementedException();
        }
    }
}
