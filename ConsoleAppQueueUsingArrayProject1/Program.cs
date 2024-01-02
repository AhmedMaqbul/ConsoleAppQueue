using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueUsingArrayProject1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue(5);
            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);
            myQueue.Add(5);
            myQueue.Add(6);

            while(!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Peek());
                myQueue.Remove();
            }

            Console.ReadLine();
        }
    }
}
