using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Abstruct_Class
{
    public abstract class Person
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }
        public string Address { get; set; }

        public abstract void GetInfo();
    }
}
