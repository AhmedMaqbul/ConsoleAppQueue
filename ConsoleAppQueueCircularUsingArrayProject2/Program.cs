using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueCircularUsingArrayProject2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue circularQueue = new MyCircularQueue(5);
            circularQueue.Add(1);
            circularQueue.Add(2);
            circularQueue.Add(3);
            circularQueue.Add(4);
            circularQueue.Add(5);

            Console.WriteLine(circularQueue.Remove());
            circularQueue.Add(6);

            Console.WriteLine(circularQueue.Remove());
            circularQueue.Add(7);

            while (!circularQueue.IsEmpty())
            {
                Console.WriteLine(circularQueue.Peek());
                circularQueue.Remove();
            }

            Console.ReadLine();
        }
    }
}
