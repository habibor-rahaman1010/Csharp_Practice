using System;

namespace TupleDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //method 1 to create tupple in c# programming language....
            Tuple<int, string, string> habib = new Tuple<int, string, string>
            (item1:144369, item2:"Habibor Rahaman", "habibor.rahaman1010@gmail.com");
            Console.WriteLine(habib);

            //method 2 to create tupple in c# programming language....
            Tuple<int, string, string> tamim = new Tuple<int, string, string>
            (144369, "Habibor Rahaman", "habibor.rahaman1010@gmail.com");
            Console.WriteLine(habib);

            //method 3 to create tupple in c# programming language....
            (int, string, string) obj = (144369, "Habibor Rahaman", "habibor.rahaman1010@gmail.com");
            Console.WriteLine(obj);

            //method 4 to create tupple in c# programming language....
            var data = (12632, name:"Tamim Ahmed", email:"tamim@gmail.com");
            Console.WriteLine(data.email);

            //method 5 to create tupple in c# programming language....
            (string, string, string) names = ("Habibor Rahaman", "Reaft", "Allen");
            Console.WriteLine(names);

            //method 6 to create tupple in c# programming language....
            ValueTuple<int, string> person = new ValueTuple<int, string> (item1:25, "John");
            Console.WriteLine(person);

            //method 7 to create tupple in c# programming language....
            ValueTuple<int, string> perso2 = (25, "John");
            Console.WriteLine(perso2);

            //method 8 to create tupple in c# programming language....
            Tuple<int, string, string> person3 = new (item1: 144369, item2: "Habibor Rahaman", "habibor.rahaman1010@gmail.com");
            Console.WriteLine(person3);

            //method 9 to create tupple in c# programming language....
            var person4 = Tuple.Create(25, "John");
            Console.WriteLine(person4);

            //method 10 to create tupple in c# programming language....
            Tuple<int, string, string> person5 = Tuple.Create(144360, "Allen", "allen@gmail.com");
            Console.WriteLine(person5);
            Console.WriteLine(person5.Item3);
        }
    }
}