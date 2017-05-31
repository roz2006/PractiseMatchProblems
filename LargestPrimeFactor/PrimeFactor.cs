using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    public class PrimeFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(13195));
            Console.WriteLine(Calculate(600851475143));
        }

        public static bool IsPrime(long n)
        {
            bool _isPrime = false;

            if (n == 1)
                _isPrime = false;
            else if (n == 2)
                _isPrime = true;
            else
            {
                _isPrime = true;
                long loopcounter = (int)n / 2;
                int i = 2;
                do
                {
                    if (n % i == 0)
                    { _isPrime = false; break; }
                    else
                        loopcounter = (int)n / i;
                    i++;
                } while (i <= loopcounter);
                //for (long i = loopcounter; i > 1; i--)
                //{
                //    if (n % i == 0)
                //    { _isPrime = false; break; }
                //    else
                //        loopcounter = (int)n / i;
                //}
            }
            return _isPrime;
        }

        static long Calculate(long max)
        {
            long _largestPrime = 0;
            long counter = 0;
            do
            {
                counter++;
                if ((max % counter == 0) && IsPrime(counter))
                    _largestPrime = counter;
            } while (counter < Math.Ceiling(Math.Sqrt(max)));

            if ((_largestPrime == 0) && IsPrime(max))
                _largestPrime = max;

            return _largestPrime;
        }

    }
}
