using System;

namespace LinqQuery
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            List<Person> persons = new List<Person>() 
            {
                new Person() {Id = 1, Name = "Habibor Rahaman", Email = "habibor.rahaman1010@gmail.com", BirthDate = DateTime.Now, Age = 24},
                new Person() {Id = 2, Name = "Wahidur Rahaman", Email = "wahidur.rahaman23@gmail.com", BirthDate = DateTime.Now, Age = 25},
                new Person() {Id = 3, Name = "Foez Ahamed", Email = "foez12@gmail.com", BirthDate = DateTime.Now, Age = 35},
                new Person() {Id = 4, Name = "Talha Jubayer", Email = "talha342@gmail.com", BirthDate = DateTime.Now, Age = 21},
                new Person() {Id = 5, Name = "Abdullah Sheikh", Email = "abdullah83@gmail.com", BirthDate = DateTime.Now, Age = 9},
                new Person() {Id = 6, Name = "Mahmudullah Sheikh", Email = "mahmudullah0101@gmail.com", BirthDate = DateTime.Now, Age = 6},
                new Person() {Id = 7, Name = "Mursalin Sabuj", Email = "mursalin1010@gmail.com", BirthDate = DateTime.Now, Age = 30},
                new Person() {Id = 8, Name = "Rifat Ahamed", Email = "rifatahmed121@gmail.com", BirthDate = DateTime.Now, Age = 24},
            };

            IEnumerable<Person> data = from p in persons where p.Age == 24 select p;

            IEnumerable<string> name = from n in data where n.Name.Length > 12 select n.Name;

            IEnumerable<Person> collection = from queryPersosn in persons where queryPersosn.Id > 4 select queryPersosn;

            foreach (Person item in data)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
            }

            foreach (string item in name)
            {
                Console.WriteLine($"Name: {item}");
            }

            foreach (Person item in collection)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Email: {item.Email}");
            }

            Console.WriteLine("\nusing by for loop\n");

            //whene use for loop

            List<Person>? data2 = (from p in persons where p.Age == 24 select p).ToList();

            List<string> name2 = (from n in data where n.Name.Length > 12 select n.Name).ToList();

            List<Person> collection2 = (from queryPersosn in persons where queryPersosn.Id > 4 select queryPersosn).ToList();

            for (int i = 0; i < data2.Count; i++)
            {
                Console.WriteLine($"Id: {data2[i].Id} Name: {data2[i].Name}");
            }

            for (int i = 0; i < name2.Count; i++)
            {
                Console.WriteLine($"Name: {name2[i]}");
            }

            for (int i = 0; i < collection2.Count; i++)
            {
                Console.WriteLine($"Id: {collection2[i].Id} Name: {collection2[i].Name} Email: {collection2[i].Email}");
            }
        }
    }
}
