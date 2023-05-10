namespace TypeCasting
{
    class Casting
    {
        static void Main(string[]args)
        {
            //implicit casting in c#...
            int age = 23;
            double age2 = age;
            Console.WriteLine(age);
            Console.WriteLine(age);

            //Explicite type casting in c#...
            double cgpa = 3.88;
            int cgpa1 = (int)cgpa;
            Console.WriteLine(cgpa1);

            //type conversion built in methods in c# programming language...
            string name = "20";
            Console.WriteLine(Convert.ToInt32(name));

            int n = 1;
            Console.WriteLine(Convert.ToBoolean(n));

            string roll = "144369";
            Console.WriteLine(Convert.ToInt64(roll));
            Console.WriteLine(Convert.ToInt64(roll).GetType());

        }
    }
}
