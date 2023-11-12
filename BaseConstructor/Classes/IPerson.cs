using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor.Classes
{
    public interface IPerson
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Country { get; set; }
        string City { get; set; }
        string Religion { get; set; }
        string Phone { get; set; }

        public void GetPersionInfo();
        public void PersonWalk();
    }
}
