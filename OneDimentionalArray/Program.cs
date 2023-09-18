using System;

namespace OneDimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1 to decklear array in c# programming language...
            int[] number = new int[5];
            number[0] = 12;
            number[1] = 23;
            number[2] = 34;
            number[3] = 65;
            number[4] = 50;
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);  
            }

            //Method 2 to decklear array in c# programming language...
            string[] friends = new string[] {"Habib", "Rifat", "Arafat", "Iftekhar", "Wahid"};

            for(int i = 0; i < friends.Length; i++)
            {
                string friend = friends[i];
                Console.WriteLine(friend);
            }

            //Method 3 to decklear array in c# programming language...
            int[] age;
            age = new int[3];
            age[0] = 12;
            age[1] = 23;
            age[2] = 90;

            //Method 4 to decklear array in c# programming language...
            int[] marks;
            marks = new int[3] {89, 83, 100};

            //value reset in array
            marks[0] = 93;
            marks[1] = 98;
            marks[2] = 91;

            //Method 5 to decklear array in c# programming language...
            int[] data = {23, 54, 23, 87, 22};

            //Method 6 to decklear array in c# programming language...
            string[] car;
            car  = new string[1];
            car[0] = "Toyota";
            car[1] = "Marcidies";

            //Method 7 to decklear array in c# programming language...
            int[] serial_number = (int[]) Array.CreateInstance(typeof(int), 5);
            serial_number[0] = 12;
            serial_number[1] = 23;
            serial_number[2] = 74;
            serial_number[3] = 19;
            serial_number[4] = 7;
        }
    }
}