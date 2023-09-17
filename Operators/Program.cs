namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            if (condition == true)
            {
                Console.WriteLine("Ok i'm going yet");
            }
            else
            {
                Console.WriteLine("i'm not go yet");
            }

            int age = 23;
            if (age == 23)
            {
                Console.WriteLine("Hello, Habibor Rahaman");
            }
            else
            {
                Console.WriteLine("Yor are not habib");
            }

            if (age != 23)
            {
                Console.WriteLine("There are not equal");
            }
            else
            {
                Console.WriteLine("There are equeal");
            }

            if (age <= 30 || age >= 60)
            {
                Console.WriteLine("you are able to go");
            }
            else
            {
                Console.WriteLine("Your are not able to go");
            }


            if (age <= 30 && age >= 15)
            {
                Console.WriteLine("you are able to go");
            }
            else
            {
                Console.WriteLine("Your are not able to go");
            }

            int vot = 28;
            if (vot <= 15)
            {
                Console.WriteLine("You not allow of vot");
            }
            else if (vot >= 18)
            {
                Console.WriteLine("You can also allow to vot");
            }

            string result = (vot >= 18) ? "You can give vot" : "You can't give vot";
            Console.WriteLine(result);
            string result2 = (vot <= 18) ? "You can give vot" : "You can't give vot";
            Console.WriteLine(result2);
        }
    }
}
