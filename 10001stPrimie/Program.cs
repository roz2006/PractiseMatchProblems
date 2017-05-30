using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrimie
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int index = 0;
            int input = 10001;//10001
            do
            {
                if (LargestPrimeFactor.PrimieFactor.IsPrime(counter))
                    index++;
                if (index == input)
                    break;
                counter++;
            } while (true);

            Console.WriteLine(counter);
        }
    }
}
