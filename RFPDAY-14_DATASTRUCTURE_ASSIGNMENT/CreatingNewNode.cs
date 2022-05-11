using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDAY_14_DATASTRUCTURE_ASSIGNMENT
{
    internal class CreatingNewNode
    {
        public Nodes head ;
        //new node at front
        public void NewNodeAtFront(int new_data)
        {
            //Allocate the node and put in the data
            Nodes New_Node = new Nodes(new_data);
            //make next of new node as head
            New_Node.next = head;
            //move the head to point to new node
            head = New_Node;
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
