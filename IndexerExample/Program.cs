using System;

namespace IndexerExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            KeyBoard keyBoard = new KeyBoard();
            Console.WriteLine(keyBoard[0]);

            Console.WriteLine(keyBoard[1, 1]);
        }
    }
}
