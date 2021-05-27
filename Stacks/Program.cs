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
            Stack<int> myStack = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6 });

            foreach (int item in myStack)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();

            Console.WriteLine("\n" + "Push 7");
            myStack.Push(7);
            Console.WriteLine(String.Join(", ", myStack));

            Console.WriteLine("\n" + "Pop");
            myStack.Pop();
            Console.WriteLine(String.Join(", ", myStack));

            Console.WriteLine("\n" + "Clearing stack...");
            myStack.Clear();
            Console.WriteLine($"Element count: {myStack.Count}");

            Console.ReadLine();
        }
    }
}