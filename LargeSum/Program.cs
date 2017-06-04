using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\roz\Documents\hundred_numbers.txt";
            char[,] matrix = FillGrid(filename);
            List<BigInteger> res = Sum(matrix);
            int count = 1;
            do
            {
                Console.Write(res.ElementAt((res.Count - count)));
                count++;
            } while (count != 11);

        }

        static char[,] FillGrid(string filename)
        {
            char[,] numbers = new char[100, 50];
            string[] alllines = File.ReadAllLines(filename);

            if (alllines.Length != 100)
                Console.WriteLine("The number of figures are not 100.");
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    char[] number = alllines[i].Trim().ToCharArray();
                    for (int j = 0; j < 50; j++)
                    {
                        numbers[i, j] = number[j];
                    }
                }
            }
            return numbers;
        }

        static List<BigInteger> Sum(char[,] matrix)
        {
            List<BigInteger> sum = new List<BigInteger>();
            BigInteger up = 0;
            for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
            {
                BigInteger sum_column = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum_column += (int)char.GetNumericValue(matrix[j, i]);
                }
                sum_column += up;
                sum.Add((BigInteger)sum_column % 10);
                up = (BigInteger)sum_column / 10;
            }
            //BigInteger reminder = up;
            do
            {
                sum.Add((BigInteger)up % 10);
                up = (BigInteger)up / 10;
            } while (up >= 10);
            if (up > 0)
                sum.Add(up);
            return sum;
        }

    }
}
