using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class DeleteANode
    {
        public Node head;
        public DeleteANode(Node h)
        {
            head = h;
        }

        public void DeleteNode(int pos)
        {
            //store the head;
            Node curr = head;
            // if the head is to be removed
            if (pos == 0)
            {
                head = curr.next;
            }

            // find the prev node of the node to be del
            int i = 0;
            while (i < pos - 1 && curr != null)
            {
                curr = curr.next;
                i++;
            }

            //if the position is more than the length of the curr list
            if (curr == null || curr.next == null)
                return;

            // delete the node
            curr.next = curr.next.next;

        }
    }
}
