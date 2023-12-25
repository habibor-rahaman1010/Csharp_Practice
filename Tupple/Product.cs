﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupple
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }

        public (string, int) ConcatString(string a, string b)
        {
            string result = a + b;
            return(result, result.Length);
        }
    }
}
