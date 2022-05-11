using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDAY_14_DATASTRUCTURE_ASSIGNMENT
{
    internal class SimpleLinkedList
    {
        LinkedList<int> myList= new LinkedList<int>();
        public void simpleLinkedList()
        {
            myList.AddLast(56);
            myList.AddLast(30);
            myList.AddLast(70);

        }
        public void display()
        {
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
