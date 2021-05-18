using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Tree<T>
    {
        public Tree<T> Parent;
        public T Data;
        public List<Tree<T>> children = new List<Tree<T>>();

        public Tree(T data)
        {
            this.Data = data;
        }

        public void AddChild(T data)
        {
            Tree<T> child = new Tree<T>(data) { Parent = this };
            children.Add(child);
        }

        public void RemoveChild(Tree<T> node)
        {
            children.Remove(node);
        }

        public void PrintTree(int i = 0)
        {
            string indent = new string(' ', i*8);
            Console.WriteLine(indent + Data);

            i++;

            foreach(var child in children)
            {
                child.PrintTree(i);
            }
        }
    }
}
