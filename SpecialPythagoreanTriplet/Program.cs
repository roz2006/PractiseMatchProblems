using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
        }


        static int Calculate()
        {
            int res = 0;
            double k = 0;
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    k = Math.Sqrt(i * i + j * j);

                    if ((int)k == k && i + j + k == 1000)
                    { res = i * j * (int)k; break; }
                }
                if (res != 0)
                    break;
            }
            return res;
        }
    }
}
