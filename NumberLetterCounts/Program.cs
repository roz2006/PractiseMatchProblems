using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NumberLetterCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = Factorial(100);
            Console.WriteLine(n);
           char[] digits=n.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Char.GetNumericValue(digits[i]);
            }
            Console.WriteLine(sum);
        }

        static BigInteger Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return Factorial(n - 1) * n;
        }
    }
}
