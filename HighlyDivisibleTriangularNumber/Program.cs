using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangularNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int number = 0;
            int i = 1;
            do
            {
                number = GetNextTriangle(i);
                count = GetNumberDivisor(number);
                i++;
            } while (count < 500);
            Console.WriteLine("Number is {0}, number of divisors is {1}",number,count);
        }

        static int GetNextTriangle(int n)
        {
            int number = 0;
            for (int i = 1; i < n+1; i++)
            {
                number += i;
            }
            return number;
        }

        static int GetNumberDivisor(int number)
        {
            int divisors = 0;
            for (int i = 1; i < (int)Math.Sqrt(number)+1; i++)
            {
                if (number % i == 0)
                    divisors+=2;
            }
            return divisors+1;
        }
    }
}
