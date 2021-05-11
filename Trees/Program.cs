using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> t = new Tree<string>("node 0");

            t.AddChild("node 1");
            t.AddChild("node 1");
            t.AddChild("node 1");
            t.AddChild("node 1");
            t.AddChild("node 1");

            t.children[0].AddChild("node 2");
            t.children[0].AddChild("node 2");
            t.children[1].AddChild("node 2");
            t.children[1].AddChild("node 2");
            t.children[1].AddChild("node 2");
            t.children[2].AddChild("node 2");
            t.children[2].AddChild("node 2");

            t.PrintTree();

            Console.WriteLine("\n");
            Console.WriteLine(t.children[4].Data);

            Console.ReadLine();
        }
    }
}
