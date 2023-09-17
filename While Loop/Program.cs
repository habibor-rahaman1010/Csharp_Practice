namespace WhileDoWhileLoop
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            //this is my while loop
            int range = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= range)
            {
                Console.WriteLine(i);
                i++;
            }

            //this is my do while loop
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= range);
        }
    }
}
