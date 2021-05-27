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

            //Adding children in layer 1
            t.AddChild("node A");
            t.AddChild("node B");
            t.AddChild("node C");
            t.AddChild("node D");
            t.AddChild("node E");

            
            //Adding children in layer 2 via index
            t.children[0].AddChild("node 1");
            t.children[0].AddChild("node 2");
            t.children[1].AddChild("node 3");
            t.children[1].AddChild("node 4");
            t.children[1].AddChild("node 5");


            //Adding children via variable
            Tree<string> D = t.children[3];

            D.AddChild("node 6");
            D.AddChild("node 7");


            //Printing tree
            t.PrintTree();


            Console.ReadLine();
        }
    }
}
