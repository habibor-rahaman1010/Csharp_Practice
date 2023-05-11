namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello programmer how are you?";
            Console.WriteLine(text);
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine($"Length Of string is: {text.Length}");

            //string concatenation in c# program...
            string name = "Habibor";
            string name2 = "Rahaman";
            string fullName =  name + " " + name2;
            Console.WriteLine(fullName);

            fullName = string.Concat(name, name2);
            Console.WriteLine(fullName);

            fullName = $"{name} {name2}";
            Console.WriteLine(fullName);

            Console.WriteLine(name[0]);
            Console.WriteLine(text[6]);
            Console.WriteLine(text.IndexOf("h"));
            Console.WriteLine(text.Substring(17));
            Console.WriteLine(text.Substring(text.IndexOf("h")));
            string message = "Habibor is \"very good\" person!";
            Console.WriteLine(message);
        }
    }
}
