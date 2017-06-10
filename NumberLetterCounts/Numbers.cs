using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLetterCounts
{
    class Numbers
    {
        static int SumDivisors(int n)
        {
            int sum = 0;
            if (n == 1)
                return sum = 1;
            else
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        sum += i;
                }
            return sum;
        }

        public static int Calculate(int n)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 1; i < n; i++)
            {
                d.Add(i, SumDivisors(i));
            }

            int sum = 0;
            foreach (var pair in d)
            {
                if (pair.Value < n && d[pair.Value] == pair.Key&&pair.Key!=pair.Value)
                    sum += pair.Key;
            }
            return sum;
        }
    }
}
