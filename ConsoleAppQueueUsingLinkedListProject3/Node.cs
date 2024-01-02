using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueUsingLinkedListProject3
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int data) 
        {
            this.Data = data;
            Next = null;
        }

    }
}
