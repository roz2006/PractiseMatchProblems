using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LargestProductInSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\roz\Documents\1000digitnumber.txt";
            Console.WriteLine("Opening file {0}", filename);

            try
            {
                string content = System.IO.File.ReadAllText(filename);
                Console.WriteLine(AdjacentProduct(4, content));
                Console.WriteLine(AdjacentProduct(13, content));


            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static long AdjacentProduct(int length, string n)
        {
            long product = 0;
            long max = 0;

            char[] digits = n.ToCharArray();

            for (int i = 0; i < digits.Length-(length-1); i++)
            {
                product = (int)Char.GetNumericValue(digits[i]);
                for (int j = 1; j < length; j++)
                {
                    product*= (int)Char.GetNumericValue(digits[i + j]);
                }
                if (product > max)
                    max = product;
            }
            return max;
        }
    }
}
