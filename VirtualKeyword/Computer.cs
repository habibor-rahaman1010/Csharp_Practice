using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    public class Computer
    {
        public string Name { get; set; }
        public string RAM { get; set; }
        public string processor { get; set; }
        public string Monitor { get; set; }

        public virtual string Start()
        {
            return "Computer is starting...";
        }
    }
}
