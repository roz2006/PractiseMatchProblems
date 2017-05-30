using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(4000000));
        }

        public static int Calculate(int max)
        {
            int counter = 1;
            int sum = 0;
            int number = 0;
            do
            {
                number = GetNextFibonacci(counter);
                if (IsEven(number))
                    sum += number;
                counter++;
            } while (number < max);

            return sum;
        }



        public static bool IsEven(int n)
        {
            bool b = false;
            if (n % 2 == 0)
                b = true;
            return b;
        }

        public static int GetNextFibonacci(int index)
        {
            if ((index == 1) || (index == 2))
                return index;
            else
                return GetNextFibonacci(index - 1) + GetNextFibonacci(index - 2);
        }
    }
}
