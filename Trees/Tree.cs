using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Tree<T>
    {
        public Tree<T> parent;
        public T data;
        public List<Tree<T>> children = new List<Tree<T>>();

        public Tree(T data)
        {
            this.data = data;
        }

        public void AddChild(T data)
        {
            Tree<T> child = new Tree<T>(data) { parent = this };
            children.Add(child);
        }

        public void RemoveChild(Tree<T> node)
        {
            children.Remove(node);
        }

        public void PrintTree(int i = 0)
        {
            string indent = new string(' ', i*8);
            Console.WriteLine(indent + data);

            i++;

            foreach(var child in children)
            {
                child.PrintTree(i);
            }
        }
    }
}
