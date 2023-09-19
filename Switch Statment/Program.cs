using System;

namespace SwitchSatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 6;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;

                case 2:
                    Console.WriteLine("Sunday");
                    break;

                case 3:
                    Console.WriteLine("Monday");
                    break;

                case 4:
                    Console.WriteLine("Tuesday");
                    break;

                case 5:
                    Console.WriteLine("Wednesday");
                    break;

                case 6:
                    Console.WriteLine("Thursday");
                    break;

                case 7:
                    Console.WriteLine("Friday");
                    break;

                default:
                    Console.WriteLine("No One Day Here");
                    break;
            }

            //example 2 switch case in c# program....
            int devSkillClass = 3;
            switch (devSkillClass)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;

                case 2:
                    Console.WriteLine("Sunday");
                    break;

                case 3:
                    Console.WriteLine("Monday");
                    break;

                case 4:
                    Console.WriteLine("Tuesday");
                    break;

                case 5:
                    Console.WriteLine("Wednesday");
                    break;

                case 6:
                    Console.WriteLine("Thursday");
                    break;

                case 7:
                    Console.WriteLine("Friday");
                    break;

                default:
                    Console.WriteLine("does't mach any case in this programe");
                    break;
            }
        }
    }
}
