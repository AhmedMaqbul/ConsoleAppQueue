using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueueInBuiltProject4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            while(numbers.Count > 0)
            {
                Console.WriteLine(numbers.Peek());
                numbers.Dequeue();
            }

            Console.WriteLine("-------");
            Console.WriteLine("-------");

            Deque<int> digits = new Deque<int> ();
            digits.AddToBack(1);
            digits.AddToFront(2);
            digits.AddToBack(3);
            digits.AddToFront(4);

            while (digits.Count > 0)
            {
                Console.WriteLine(digits.FirstOrDefault());
                digits.RemoveFromFront();
            }

            Console.ReadLine();
        }
    }
}
