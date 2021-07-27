using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class InsertANode
    {
        public Node head;
        public void AddToFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void InsertAfter(Node prev, int data)
        {
            if(prev == null)
            {
                Console.WriteLine("The previous node cannot be null");

            }

            Node node = new Node(data); // creating a node with the data
            node.next = prev.next; // point the next of the new node to the next of the prev node
            prev.next = node;  // make next of prev as the new node
        }

        public void AddLast(int data)
        {
            Node node = new Node(data);
            // if the list is null make the new node as head
            if (head == null) 
            {
                head = node;
                return;
            }

            //since this will be the last node, its next is pointed to a null
            node.next = null; 

            Node curr = head;

            // treverse the list to the end
            while (curr.next != null) 
            {
                curr = curr.next;
            }

            // change the next of the current node to be the new node
            curr.next = node;
            return;

        }
        public void PrintList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write($"{node.data} -> ");
                node = node.next;
            }
        }
    }
}
