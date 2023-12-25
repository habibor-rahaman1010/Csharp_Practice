using None_Generics_Datastructure;
using System;
namespace Non_Generics_Datastructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello programmer");
            Non_Generics_List datastructure = new Non_Generics_List();

            datastructure.Array_List();
            datastructure.Bit_Array();
            datastructure.Has_Table();
            datastructure.QueueList();
            datastructure.Sorted_List();
            datastructure.Stack_List();
        }
    }
}
