namespace MethodsReturn
{
    class Program
    {
        //this function return me a full name of a man...
        static String FullName(String? Fname, String? Lname)
        {
            String name = $"{Fname} {Lname}";
            return name;
        }


        //this function return sum of tow value...
        static int Sum(int x = 0, int y = 0)
        {
            return (x + y);
        }

        static void Main(string[] args)
        {
            String? name1 = Convert.ToString(Console.ReadLine());
            String? name2 = Convert.ToString(Console.ReadLine());
            String? getFullName = FullName(name1, name2);
            Console.WriteLine(getFullName);

            Console.Write(Sum(12, 23));
        }
    }
}
