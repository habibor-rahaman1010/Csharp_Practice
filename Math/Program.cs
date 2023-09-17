namespace SolveMath
{
    class Mathmatics
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the value of X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Max value is: {Math.Max(x, y)}");
            Console.WriteLine($"Min value is: {Math.Min(x, y)}");
            Console.WriteLine($"Squer rot of X: {Math.Sqrt(x)}");
            Console.WriteLine($"power of Y: {Math.Sqrt(y)}");
            Console.WriteLine($"Abs od x and y: {Math.Abs(x + y)}");

            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Price is rounded: {Math.Round(price + x)}");
            Console.WriteLine($"Price is floor: {Math.Floor(price + x)}");
            Console.WriteLine($"Price is rounded: {Math.Ceiling(price + x)}");
        }
    }
}
