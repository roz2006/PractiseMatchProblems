using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitipleOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Total3And5Multiple(1000));
        }

        static int Total3And5Multiple(int max)
        {
            int sum = 0;
            for (int i = 1; i < max; i++)
            {
                if ((i % 3 == 0)|| (i % 5 == 0))
                      sum += i;
            }

            return sum;
        }
    }
}
