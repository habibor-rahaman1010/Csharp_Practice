namespace Methods
{
    class MethodsProgram
    {
        //this is my method here...
        static void PrintName()
        {
            string name = "Habibor Rahaman";
            Console.WriteLine(name);
        }

        //this is my parameterised methods
        static void PrintDescription(string text)
        {
            Console.WriteLine(text);
        }

        //multiple parameter use in this method
        static void DogSound(string s1, string s2)
        {
            Console.WriteLine($"{s1} {s2}");
        }


        //default parameter use in this method...
        static void Sum(int x = 200, int y = 100)
        {
            Console.WriteLine(x + y);
        }

        static void Main(string[] args)
        {
            PrintName();
            PrintName();

            string data = "I'm a Csharp programmer. This is my most loved programming language.";
            PrintDescription(data);

            string s1 = "Gheww";
            string s2 = "Veww";
            DogSound(s1, s2);

            int x = 10;
            int y = 30;
            Sum(12, 17);
        }
    }
}
