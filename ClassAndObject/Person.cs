using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Person
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        private int _balnce = 0;

        public int Balnce 
        { 
            get { return _balnce; }
            set {
                if(value < 0)
                {
                    _balnce = 0;
                }
                else
                {
                    _balnce = value;
                }
            }
        }

        public Person()
        {
            //This is my default constructor....
        }
        public Person(int id, string name, string email, int balance)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this._balnce = balance;
        }
    }
}
