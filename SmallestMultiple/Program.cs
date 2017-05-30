using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(20));

            long product = 1;
            for (int i = 1; i < 20+1; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }

        static int Calculate(int max)
        {
            int res = 0;
            try
            {
                bool flag = true;
                int counter = 1;
                do
                {
                    for (int i = 1; i < max+1; i++)
                    {
                        if (counter % i != 0)
                        { counter++; break; }
                        
                        if(i==max)
                            flag = false;
                    }
                } while (flag);
                res = counter;
            }

            catch (OverflowException)
            {
                Console.WriteLine("Overflow of number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            return res;

        }
    }
}
