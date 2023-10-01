using System;

namespace BitwiseOperation
{
    class Program
    {
        static void Main(string[] args)
        { 
            int age = 23;
            bool operation = age > 10 && age < 100;
            Console.WriteLine(operation);

            operation = age < 10 || age < 100;
            Console.WriteLine(operation);

            operation = age != 23;
            Console.WriteLine(operation);

            operation = age != 20;
            Console.WriteLine(operation);

            uint n1 = 0b_11001011;
            Console.WriteLine(Convert.ToString(n1, toBase: 2));

            //toggle operation om binary number....
            uint n2 = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            Console.WriteLine(Convert.ToString(n2, toBase: 2));
            uint n3 = ~n2;
            Console.WriteLine(Convert.ToString(n3, toBase: 2));

            //left shift operator user in binary number...
            uint b1 = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b2 = b1 << 4;
            Console.WriteLine(Convert.ToString(b2, toBase: 2));

            //right shift operator user in binary number...
            uint b3 = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b4 = b3 >> 2;
            Console.WriteLine(Convert.ToString(b4, toBase: 2));

            // And operation in binary number...
            uint a = 0b_0101_1010;
            uint b = 0b_1100_0011;
            uint c = a & b;
            Console.WriteLine(Convert.ToString(c, toBase: 2));

            // Or operation in binary number...
            uint x = 0b_0101_1010;
            uint y = 0b_1100_0011;
            uint z = x | y;
            Console.WriteLine(Convert.ToString(z, toBase: 2));

            // Xor operation in binary number...
            uint n = 0b_0101_1010;
            uint m = 0b_1100_0011;
            uint k = n ^ m;
            Console.WriteLine(Convert.ToString(k, toBase: 2));

            //This is my simple decimal to binary calculator...
            while (true)
            {
                Console.WriteLine("Enter your decimal number: ");
                string input = Console.ReadLine();

                try
                {
                    long decimalValue = long.Parse(input);
                    Console.WriteLine("Binary: {0}", Convert.ToString(decimalValue, toBase: 2));
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }
            }
        }
    }
}
