using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (long i = 1; i < 2000000; i++)
            {
                if (LargestPrimeFactor.PrimeFactor.IsPrime(i))
                    sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
