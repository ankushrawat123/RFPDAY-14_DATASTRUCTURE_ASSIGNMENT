using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDAY_14_DATASTRUCTURE_ASSIGNMENT
{
    internal class Nodes
    {
        //* 1. Allocate the Node &
        // 2. Put in the data
        // 3. Set next as null */
        public int data;
        public Nodes next;
        public Nodes(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
