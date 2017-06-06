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
        static Hashtable ht = new Hashtable();
        static void Main(string[] args)
        {
            Calculate();
        }

        static void Calculate()
        {
            int maxcount = 0;
            for (int i = 1; i < 2000000; i++)
            {
                int next = 0;
                int count = 1;
                int start = i;
                do
                {
                    if ((ht.ContainsKey(start)))
                    { count += (int)ht[start] - 1; break; }
                    next = GetNextCollatzNumber(start);
                    start = next;
                    count++;
                } while (next != 1);

                if (!ht.Contains(i))
                    ht.Add(i, count);

                if (count > maxcount)
                    maxcount = count;
            }
            Console.WriteLine(maxcount);
        }

        static int GetNextCollatzNumber(int n)
        {
            int next = 0;
            if (n % 2 == 0)
                next = (int)n / 2;
            else
                next = 3 * n + 1;
            return next;
        }
    }
}
