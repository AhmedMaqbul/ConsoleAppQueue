using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueCircularUsingArrayProject2
{
    public class MyCircularQueue
    {
        public int[] MyArray;
        public int Size;
        public int Rear = -1;
        public int Front = -1;

        public MyCircularQueue(int length)
        {
            this.MyArray = new int[length];
            this.Size = length;
        }

        public bool IsEmpty()
        {
            return Rear == -1 && Front == -1;
        }

        public bool IsFull()
        {
            return (Rear + 1) % Size == Front;
        }

        public void Add(int data)
        {
            if(IsEmpty())
            {
                Console.WriteLine("Full Queue");
                return;
            }

            //1st element add
            if(Front == -1)
            {
                Front = 0;

            }

            Rear = (Rear + 1) % Size;
            MyArray[Rear] = data;
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }

            int result = MyArray[Front];

            //single element condition
            if (Rear == Front)
            {
                Rear = Front = -1;
            }  
            else
            {
                Front = (Front + 1) % Size;
            }

            return result;
        }

        public int Peek()
        {
            if(IsEmpty()) 
            {
                Console.WriteLine("Empty Queue");
                return -1;
            }

            return MyArray[Front];
        }
    }
}
