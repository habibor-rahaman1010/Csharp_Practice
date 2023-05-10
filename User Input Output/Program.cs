namespace UserInput
{
    class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string? name = Console.ReadLine();
            Console.WriteLine(name);

            int x, y, ans;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            ans = x + y;
            Console.WriteLine(ans);


            double semester1, semester2, semester3, semester4;
            Console.WriteLine("Input semester 1: ");
            semester1 = Convert.ToDouble(Console.ReadLine());
            semester2 = Convert.ToDouble(Console.ReadLine());
            semester3 = Convert.ToDouble(Console.ReadLine());
            semester4 = Convert.ToDouble(Console.ReadLine());

            double result = (semester1 + semester2 + semester3 + semester4);
            Console.WriteLine($"Total result is: {result / 4}");
        }
    }
}
