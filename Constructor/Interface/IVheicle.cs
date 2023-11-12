using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Interface
{
    internal interface IVheicle
    {
        string Name { get; set; }
        string Color { get; set; }
        int Price { get; set; }
        public void Start();
        public void Move();
    }
}
