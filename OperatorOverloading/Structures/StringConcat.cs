using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Structures
{
    public struct StringConcat
    {
        private readonly string _string1;
        private readonly string _string2;

        public StringConcat(string string1, string string2) {
            _string1 = string1;
            _string2 = string2;
        }

        public static StringConcat operator +(StringConcat a, StringConcat b)
        {
            return new StringConcat(a._string1 + " "+ a._string2,  b._string1 + " "+ b._string2);
        }

        public override string ToString()
        {
            return $"{_string1} {_string2}";
        }
    }
}
