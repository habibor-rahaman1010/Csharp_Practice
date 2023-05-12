namespace MultidimensionalArrays
{
    class Multidimension
    {
        static void Main(string[] args)
        {
            int[,] age = { { 2, 23, 11 }, { 31, 45, 39 } };
            int[,] number = new int[,] { { 1, 4, 2}, { 3, 6, 8} };

            //loop in 2d array in c# program...
            for (int i = 0; i < age.GetLength(0); i++)
            {
                for (int j = 0; j < age.GetLength(1); j++)
                {
                    Console.Write(age[i, j] + " ");
                }
            }
            Console.WriteLine();

            //foreach loop run on the number array...
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //set new value and loop in 2d array in c# program...
            age[0, 0] = 55;
            age[1, 2] = 100;
            age[1, 1] = 48;
            for (int i = 0; i < age.GetLength(0); i++)
            {
                for (int j = 0; j < age.GetLength(1); j++)
                {
                    Console.Write(age[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
