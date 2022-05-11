using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDAY_14_DATASTRUCTURE_ASSIGNMENT
{
    internal class CreatingNodeAtEnd
    {
        public Nodes head;
        public void NewNodeAtEnd(int newdata)
        {
            //* 1. Allocate the Node &
            // 2. Put in the data
            // 3. Set next as null */
            Nodes new_node = new Nodes(newdata);

            //* 4. If the Linked List is empty,
             //  then make the new node as head */
            if (head == null)
            {
                head = new Nodes(newdata);
                return;
            }

            //* 4. This new node is going to be
            //the last node, so make next of it as null */
            new_node.next = null;

            //* 5. Else traverse till the last node */
            Nodes last = head;
            while (last.next != null)
            last = last.next;

            //* 6. Change the next of last node */
            last.next = new_node;
            return;
        }
        public void print()
        {
            Nodes temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
