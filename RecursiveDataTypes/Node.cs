using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveDataTypes
{
    class Node
    {
        private int value;
        private Node child_left;
        private Node child_right;

        public Node(int v):this(v,null,null)
        {
            
        }
        public Node(int v, Node a, Node b)
        {
            this.value = v;
            this.child_left = a;
            this.child_right = b;
        }

        public void Print()
        {
            Console.WriteLine(this.value);
            if(this.child_left!=null)
                this.child_left.Print();
            if (this.child_right != null)
                this.child_right.Print();
        }
    }
}
