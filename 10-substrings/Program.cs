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
            Console.WriteLine("T(2) is: {0}", Count(2));
            Console.WriteLine("T(5) is: {0}", Count(5));
            Console.WriteLine("T(18) is: {0}", Count(18));

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
            bool res = false;
            string number = n.ToString();
            string substring;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 2; j < number.Length - i + 1; j++)
                {
                    substring = number.Substring(i, j);
                    if (SubIsTenString(substring))
                    { res = true; break; }
                }

            }
            return res;
        }

        static int Count(int n)
        {
            int res = 0;

            for (int i = 10; i < Math.Pow(10, n) + 1; i++)
            {
                if (IsNumberTenString(i)) res++;
            }

            return res;
        }
    }
}
