using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueUsingArrayProject1
{
    public class MyQueue
    {
        public int[] MyArray;
        public int Size;
        public int Rear = -1;
        public MyQueue(int length) 
        { 
            MyArray = new int[length];
            this.Size = length;
        }
        
        public bool IsEmpty()
        {
            return Rear == -1;
        }

        //Enqueue
        public void Add(int value)
        {
            if (Rear == Size - 1)
            {
                Console.WriteLine("Full Queue");
                return;
            }

            Rear++;
            MyArray[Rear] = value;
        }

        //Dequeue
        public int Remove()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }

            int front = MyArray[0];

            for(int i = 0; i < Rear; i++)
            {
                MyArray[i] = MyArray[i + 1];
            }

            Rear--;
            return front;
        }

        //Peek
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty queue");
                return -1;
            }
            return MyArray[0];
        }
    }
}
