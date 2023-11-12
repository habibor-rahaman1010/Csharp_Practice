using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct_Class.Abstruct_classes
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public string Color { get; set; }
        public string CarType { get; set; }

        public abstract void LoadFuel();
        public abstract void GetInfo();
    }
}
