using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Classes
{
    public partial class Person
    {
        public Person(string name, string email) { 
            this.Name = name;
            this.Email = email;
        }
    }
}
