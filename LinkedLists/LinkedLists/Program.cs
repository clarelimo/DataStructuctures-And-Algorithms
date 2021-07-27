using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an empty list
            InsertANode linkedList = new InsertANode();
            linkedList.AddLast(6);
            linkedList.AddToFront(7);
            linkedList.AddToFront(1);
            linkedList.AddLast(4);
            linkedList.InsertAfter(linkedList.head.next, 8);
            Console.WriteLine("The linked list created is");
            linkedList.PrintList();

            DeleteANode linkedList2 = new DeleteANode(linkedList.head);
            linkedList2.DeleteNode(3);
            Console.WriteLine("Delete a node at a given position");
            linkedList.PrintList();
            
        }
    }
}
