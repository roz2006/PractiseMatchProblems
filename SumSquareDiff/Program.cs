using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(10));
            Console.WriteLine(Calculate(100));
        }

        static int Calculate(int max)
        {
            int res = 0;
            int sum = 0;
            for (int i = 1; i < max+1; i++)
            {
                res += (int)Math.Pow(i, 2);
                sum += i;
            }
            res = (int)Math.Pow(sum, 2) -res;
          return res;
        }
    }
}
