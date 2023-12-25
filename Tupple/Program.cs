using System;
using Tupple;

namespace PracticeTupple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[] 
            {
                new Product { Name = "Laptop", Price = 15340.45, Description = "This is good product", Category = "Gadget", Color = "silver"},
                new Product { Name = "Computer", Price = 45340.45, Description = "This is good product", Category = "Gadget", Color = "black" },
                new Product { Name = "iphone", Price = 23340.45, Description = "This is good product", Category = "Gadget", Color = "blue" },
            };

            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Description: {product.Description}, Category: {product.Category}, Color: {product.Color}");
            }

            double max = double.MinValue;
            (double, string) topProduct = (0, null);
            foreach(Product item in products)
            {
                if(item.Price > max)
                {
                    max = item.Price;
                    topProduct.Item1 = item.Price;
                    topProduct.Item2 = item.Name;
                }
            }
            var t = Tuple.Create(34, 34);
            Console.WriteLine($"Price: {topProduct.Item1}, Name: {topProduct.Item2}");
            
            (string, int) Concat(string a, string b){
                string result = a + b;
                return (result, result.Length);
            }
            (string name, int nameCount) habib = Concat("habibor", "rahaman");
            Console.WriteLine($"Name: {habib.name}, NameCount: {habib.nameCount}");

            Product laptop = new Product();
            (string text, int size) output = laptop.ConcatString("lanevo", "laptop");
            Console.WriteLine(output.text);
            Console.WriteLine(output.size);
        }
    }
}
