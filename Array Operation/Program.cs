namespace ArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "Volvo", "Aston Martin", "Jegure", "Voxwagen", "Mercidies", "Toyota"};
            Array.Sort(cars);
            for (int i = 0; i < cars.Length; i++)
            {
                String data = cars[i];
                Console.WriteLine(data);
            }

            int[] number = new int[] { 23, 34, 24, 12, 45, 67, 86, 10, 17, 20 };
            Array.Sort(number);
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            Console.WriteLine($"Max value in number array: {number.Max()}");
            Console.WriteLine($"Min value in number array: {number.Min()}");
            Console.WriteLine($"Sum of the number array: {number.Sum()}");
            Console.WriteLine($"Average of the number array: {number.Average()}");
        }
    }
}
