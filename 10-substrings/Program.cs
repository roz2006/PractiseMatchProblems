using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("T(2) is: {0}", Count(10,2));
            Console.WriteLine("T(3) is: {0}", Count(10, 3));
            //Console.WriteLine("T(4) is: {0}", Count(4));
            Console.WriteLine("T(5) is: {0}", Count(10,5));
            //Console.WriteLine("T(18) is: {0}", Count(18));

        }

        double inputArg = Math.Pow(10, 18);

        static bool SubIsTenString(string n)
        {
            bool res = false;
            int sum = 0;
            int digit = 0;

            Char[] number = n.ToCharArray();
            foreach (var item in number)
            {
                digit = (int)Char.GetNumericValue(item);
                sum += digit;
                if (sum == 10)
                { res = true; break; }
            }

            return res;
        }

        static bool IsNumberTenString(int n)
        {
            string number = n.ToString();
            bool[] res = new bool[number.Length];
            string substring;
            bool result = false;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 2; j < number.Length - i + 1; j++)
                {
                    substring = number.Substring(i, j);
                    if (SubIsTenString(substring))
                    {
                        for (int k = 0; k < substring.Length; k++)
                        {
                            res[i + k] = true;
                        }
                    }
                    if (CheckResult(res)) { result = true; break; }
                }
                if (CheckResult(res)) { result = true; break; }
            }
            return result;
        }

        static bool CheckResult(bool[] res)
        {
            bool result = res[0];
            for (int i = 1; i < res.Length; i++)
            {
                result &= res[i];
            }
            return result;
        }
        static int Count(int s, int n)
        {
            int res = 0;

            for (int i = s; i < Math.Pow(10, n) + 1; i++)
            {
                if (IsNumberTenString(i)) res++;
            }
            return res;
        }
    }
}
