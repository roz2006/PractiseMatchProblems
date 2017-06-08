using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LongestCollatzSequence
{
    class Program
    {
        static Dictionary<long, long> dt = new Dictionary<long, long>();
        static void Main(string[] args)
        {
            Calculate();
        }

        static void Calculate()
        {
            long maxcount = 0;
            for (int i = 1; i < 1000000; i++)
            {
                long count = 1;
                long next = i;
                do
                {
                    if ((dt.ContainsKey(next)))
                    { count += dt[next] - 1; break; }

                    if (next % 2 == 0)
                        next = (long)next / 2;
                    else
                        next = 3 * next + 1;
                    count++;
                } while (next != 1);

                if (!dt.ContainsKey(i))
                    dt.Add(i, count);

                if (count > maxcount)
                    maxcount = count;
            }
            GetKey(dt, maxcount);
        }

        static void GetKey(Dictionary<long, long> d, long v)
        {
            foreach (long key in d.Keys)
            {
                if (d[key] == v)
                    Console.WriteLine(key);
            }
        }
    }
}
