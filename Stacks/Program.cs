using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(new int[] { 2, 3, 1, 5, 4 });

            foreach (int item in myStack)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();

            myStack.Pop();

            Console.WriteLine(String.Join(", ", myStack));

            myStack.Clear();

            Console.WriteLine("Clearing stack...");
            Console.WriteLine($"Element count: {myStack.Count}");

            Console.ReadLine();
        }
    }
}