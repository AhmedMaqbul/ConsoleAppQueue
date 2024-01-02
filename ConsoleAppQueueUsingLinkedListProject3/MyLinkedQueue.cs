using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueUsingLinkedListProject3
{
    public class MyLinkedQueue
    {
        public Node Head = null;
        public Node Tail = null;

        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);

            //adding for first node, tail and head must be null
            if(Tail == null)
            {
                Tail = Head = newNode;
                return;
            }

            Tail.Next = newNode;
            Tail = newNode;
        }
        public int Remove()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }

            int front = Head.Data;

            //queue has single element head will be null and tail must be null
            if(Head == Tail)
            {
                Tail = null;
            }

            Head = Head.Next;

            return front;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }

            return Head.Data;
        }
    }
}
