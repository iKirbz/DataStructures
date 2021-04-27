using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 4, 5 };

            Console.WriteLine("Creating new list:");
            Console.WriteLine(String.Join(" -> ", list) + "\n");

            DisplayAddingElements(list);

            DisplayInsertingElements(list);

            DisplayDeletingElements(list);

            DisplaySearchingElement(list);

            DisplayElementCount(list);

            DisplayListClear(list);

            Console.ReadLine();
        }

        private static void DisplayAddingElements(List<int> list)
        {
            Console.WriteLine("Adding new number 7:");
            list.Add(7);
            Console.WriteLine(String.Join(" -> ", list) + "\n");
        }

        private static void DisplayInsertingElements(List<int> list)
        {
            Console.WriteLine("Inserting 3 at index 1:");
            list.Insert(1, 3);
            Console.WriteLine(String.Join(" -> ", list) + "\n");
        }

        private static void DisplayDeletingElements(List<int> list)
        {
            Console.WriteLine("Deleting number at index 2:");
            list.RemoveAt(2);
            Console.WriteLine(String.Join(" -> ", list) + "\n");
        }

        private static void DisplaySearchingElement(List<int> list)
        {
            Console.WriteLine("Seraching number 3");
            Console.WriteLine($"Index: {list.IndexOf(3)}" + "\n");
        }

        private static void DisplayElementCount(List<int> list)
        {
            Console.WriteLine("Count of elements in list:");
            Console.WriteLine(list.Count + "\n");
        }

        private static void DisplayListClear(List<int> list)
        {
            Console.WriteLine("Clearing list...");
            list.Clear();
            DisplayElementCount(list);
        }
    }
}