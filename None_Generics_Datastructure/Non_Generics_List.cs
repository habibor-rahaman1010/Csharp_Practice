using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace None_Generics_Datastructure
{
    public class Non_Generics_List
    {
        public void Array_List()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Bit_Array()
        {
            BitArray bit1 = new BitArray(5, true);
            BitArray bit2 = new BitArray(new byte[5] {1, 2, 3, 4, 5});
            foreach (var item in bit1)
            {
                Console.WriteLine(item);
            }
        }

        public void Has_Table()
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Habibor Rahaman");
            ht.Add(1, "Habib");
            ht.Add(2, "nope");

            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"{ht[item]}");
            }
        }

        public void QueueList()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("tamim");
            myQueue.Enqueue("Sabuj");
            myQueue.Enqueue("Abdur");
            myQueue.Dequeue();

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myQueue.Peek());
        }

        public void Sorted_List()
        {
            SortedList mySortedList = new SortedList();
            mySortedList.Add("name", "Saad");
            mySortedList.Add("profession", "Programmer");
            mySortedList.Add("Class", "Intermidiate");

            foreach (var item in mySortedList.Keys)
            {
                Console.WriteLine(mySortedList[item]);
            }
        }

        public void Stack_List()
        {
            Stack myStack = new Stack();
            myStack.Push("C++");
            myStack.Push("C#");
            myStack.Push("JavaScript");
            myStack.Pop();

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
