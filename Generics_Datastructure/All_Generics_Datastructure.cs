using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Generics_Datastructure
{
    public class All_Generics_Datastructure
    {
        public void DictionaryList()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Name", "Habibor Rahaman");
            dictionary.Add("Age", "23");
            dictionary.Add("Email", "habibor.rahaman1010@gmail.com");
            dictionary.Add("Address", "Dhaka");
            try
            {
                dictionary.Add("Address", "Wari");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"Address\" already exists.");
            }

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(dictionary[key]);
            }

            foreach(KeyValuePair<string, string> kvp in dictionary) 
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public void HashSetList()
        {
            HashSet<int> even = new HashSet<int>();
            HashSet<int> odd = new HashSet<int>();

            for (int i = 0; i < 20; i++)
            {
                even.Add (i * 2);
                odd.Add((i * 2) + 1);
            }

            HashSet<int> hashSet = new HashSet<int>(even);
            

            Console.Write("Hase item: ");
            foreach (var item in hashSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            HashSet<int> hashSet2 = new HashSet<int>(odd);
            Console.Write("Hase item: ");
            foreach (var item in hashSet2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        
        public void Linked_List()
        {
            string[] fruits = new string[5] { "Apple", "banana", "Papaya", "Orange", "Coconut" };
            LinkedList<string> list = new LinkedList<string>(fruits);
            list.AddFirst("Mango");
            list.AddLast("Lemon");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void QueueList()
        {
            Queue<int> list = new Queue<int>(new int[] {12, 23, 45, 56, 67});
            list.Dequeue();
            list.Enqueue(33);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void PriorityQueue()
        {
            PriorityQueue<string, int> list = new PriorityQueue<string, int>();
            list.Enqueue("habib", 5);
            list.Enqueue("Abdur", 1);
            list.Enqueue("Allen", 4);
            list.Enqueue("Abdullah", 2);
            list.Enqueue("Mahmudullah", 3);
            Console.WriteLine(list.Dequeue());

            while (list.Count > 0)
            {
                string data = list.Dequeue();
                Console.WriteLine(data);
            }
        }

        public void Sorted_Dictionary()
        {
            SortedDictionary<string, string> list = new SortedDictionary<string, string>();
            list.Add("Name", "Habib");
            list.Add("Email", "habior.rahaman1010@gmail.com");
            list.Add("Age", "23");

            foreach (KeyValuePair<string, string> kvp in list)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public void Stack_List()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4);  
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Sorted_List()
        {
           SortedList<string, string> sortList = new SortedList<string, string>();
            sortList.Add("Name", "Habib");
            sortList.Add("Age", "23");
            sortList.Add("Address", "Dhaka");
            sortList.Add("Street", "loacl");

            foreach (KeyValuePair<string, string> kvp in sortList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
