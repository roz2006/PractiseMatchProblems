using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(3));
        }

        static int Calculate(int digit)
        {
            int product = 0;
            int max = (int)Math.Pow(10, digit) - 1;
            int min = (int)Math.Pow(10, digit - 1) - 1;

            List<int> _palindromes = new List<int>();

            for (int i = max; i > min; i--)
            {
                for (int j = max; j > min; j--)
                {
                    product = i * j;
                    if (IsPalindrome(product))
                    {_palindromes.Add(product); }
                }
            }
            return _palindromes.Max();
        }

        static bool IsPalindrome(int n)
        {
            bool res = true;

            char[] s1 = n.ToString().ToCharArray();
            char[] s2 = n.ToString().ToCharArray();
            Array.Reverse(s2);
            
            for (int i = 0; i < s1.Length; i++)
            {
                if ((s1[i]!=s2[i]))
                { res = false; break; }
            }
            return res;
        }
    }
}
