using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LatticePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Lattice myLattice = new Lattice(17);
            myLattice.Travers(0, 0);
            Console.WriteLine(myLattice.Counter);
            //BigInteger a = new BigInteger();
            //a = (BigInteger)Math.Pow(2, 1000);
            //char[] b = a.ToString().ToCharArray();
            //int sum = 0;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    sum+=(int)Char.GetNumericValue(b[i]);
            //}
            //Console.WriteLine(sum);
        }
    }
}
