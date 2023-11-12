using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class.static_classes
{
    public static class RandomNumberGenerator
    {
        private static Random _random;

        static RandomNumberGenerator()
        {
            _random = new Random(DateTime.Now.Microsecond);
        }
        public static int Generate()
        {
            return _random.Next(10, 100);  
        }
    }
}
