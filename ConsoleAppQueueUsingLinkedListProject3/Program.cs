using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueUsingLinkedListProject3
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedQueue linkedQueue = new MyLinkedQueue();
            linkedQueue.Add(1);
            linkedQueue.Add(2);
            linkedQueue.Add(3);
            linkedQueue.Add(4);
            linkedQueue.Add(5);

            while (!linkedQueue.IsEmpty())
            {
                Console.WriteLine(linkedQueue.Peek());
                linkedQueue.Remove();
            }

            Console.ReadLine();
        }
    }
}
