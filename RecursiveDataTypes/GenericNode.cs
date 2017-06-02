using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RecursiveDataTypes
{
    public class GenericNode<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private GenericNode<T> left;

        public GenericNode<T> Left
        {
            get { return left; }
            set { left = value; }
        }

        private GenericNode<T> right;

        public GenericNode<T> Right
        {
            get { return right; }
            set { right = value; }
        }


        public GenericNode(T t)
        {
            Data = t;
        }

        public void AddNodes(T l, T r)
        {
            this.Left = new GenericNode<T>(l);
            this.Right = new GenericNode<T>(r);
        }

        public void AddNodes(GenericNode<T> l, T r)
        {
            this.Left = l;
            this.Right = new GenericNode<T>(r);
        }
        public void AddNodes(GenericNode<T> l, GenericNode<T> r)
        {
            this.Left = l;
            this.Right = r;
        }

        public static void ReadNode(GenericNode<T> n)
        {
            if (n != null)
            {
                Console.WriteLine(n.Data);
                ReadNode(n.Left);
                ReadNode(n.Right);
            }

        }
    }
}
