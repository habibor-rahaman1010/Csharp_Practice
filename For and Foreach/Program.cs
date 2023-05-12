namespace ForLoopForeach
{
    class FoorLoop
    {
        static void Main(string[] args)
        {
            int range = Convert.ToInt32 (Console.ReadLine());

            //this is my for loop 
            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Toyota", "Voxwagen", "Mercidies", "BMW", "Aston Mertin", "Nissan" };
            for (int i = 0; i < cars.Length; i++)
            {
                string value = cars[i];
                Console.Write($"{value}, ");  
            }
            Console.WriteLine();
            foreach (string car in cars)
            {
                Console.Write($"{car}, ");
            }

            //breack and continue in c# program...
            for (int i = 0; i <= range; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine() ;

            int j = 1;
            while (j <= range)
            {
                Console.WriteLine(j);
                j++;
                if (j == 5)
                {
                    continue;
                }
            }
        }
    }
}
