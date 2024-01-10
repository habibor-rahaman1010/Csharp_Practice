using System;
 namespace EventExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Box box = new Box();

            box.Opened += Box_Opened; 
            box.Closed += Box_Closed;
            box.Opened += Box_Opened2;
            box.Sum += GetSummation;
            box.Message += GetSMS;

            box.Open();
            box.Close();
            var result = box.Summation(10, 20);
            Console.WriteLine(result);
            box.SMS();
        }

        public static void Box_Opened(DateTime obj)
        {
            Console.WriteLine(obj);
        }

        public static void Box_Opened2(DateTime obj)
        {
            Console.WriteLine($"{obj} - {obj.DayOfWeek}");
        }

        public static void Box_Closed(DateTime obj)
        {
            Console.WriteLine(obj);
        }

        public static int GetSummation(int x, int y)
        {
            return x + y;
        }

        public static void GetSMS(object? sender, EventArgs e)
        {
            Console.WriteLine("Message Sending Succesfully...");
        }
    }
}
