using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            Console.WriteLine(String.Join(", ", myQueue));

            myQueue.Dequeue();

            Console.WriteLine(String.Join(", ", myQueue));

            Console.ReadLine();
        }
    }
}
