using System;
namespace Generics_Datastructure
{
    public class Program
    {
        public static void Main()
        {
            All_Generics_Datastructure generics_list = new All_Generics_Datastructure();

            generics_list.DictionaryList();
            generics_list.HashSetList();
            generics_list.Linked_List();
            generics_list.QueueList();
            generics_list.PriorityQueue();
            generics_list.Sorted_Dictionary();
            generics_list.Stack_List();
            generics_list.Sorted_List();
        }
    }
}
