using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node node1 = new Node(112);
            //Node node2 = new Node(176);

            //Node node3 = new Node(87, node1, node2);
            //Node node4 = new Node(256);
            //Node myTree = new Node(42, node3, node4);

            //myTree.Print();
            GenericNode<int> n1 = new GenericNode<int>(87);
            n1.AddNodes(112, 176);
            GenericNode<int> n2 = new GenericNode<int>(42);
            n2.AddNodes(n1, 256);

            GenericNode<int>.ReadNode(n2);
            
        }
    }
}
