using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDAY_14_DATASTRUCTURE_ASSIGNMENT
{
    internal class NodeAtCertainIndex
    {
        internal Nodes head; //new 
        public void Add(int data)
        {
            Nodes node = new Nodes(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Nodes temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }


        public void addAtIndex(int index, int data)
        {
            Nodes newNode = new Nodes(data);
            newNode.data = data;

            if (index == 0)
            {
                Add(data);
            }
            else
            {
                Nodes node = head;
                for (int i = 0; i < index - 1; i++)
                {
                    node = node.next;
                }
                newNode.next = node.next;
                node.next = newNode;
             
            }

            Console.WriteLine("{0} inserted into the linked list between node 56 and node 70", newNode.data);
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
