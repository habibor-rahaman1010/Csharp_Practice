using System;
namespace GenericsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BubbleSort<int> bubblesort = new BubbleSort<int>();
            int[] result = bubblesort.Sort(new int[] { 34, 45, 67, 2, 3, 10, 1 });

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Calculator<int> calculator = new Calculator<int>(23, 34);
            int ans = calculator.Sum();
            Console.WriteLine($"Sum is: {ans}");
        }
    }
}
