using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace MaximumPathSumOne
{
    class Program
    {
        static int sum = 0;
        static void Main(string[] args)
        {
            string filename = @"c:\temp\triangle.txt";
            Calculate(filename);
            
        }

        static List<int>[] GetTriangle(string filename)
        {
            string[] alllines = System.IO.File.ReadAllLines(filename);
            List<int>[] numbers = new List<int>[alllines.Length];
            Regex regex = new Regex(@"\s");
            for (int i = 0; i < alllines.Length; i++)
            {
                string[] bits = regex.Split(alllines[i]);
                List<int> l = new List<int>();
                foreach (string bit in bits)
                {
                    l.Add(int.Parse(bit));
                }
                numbers[i] = l;
            }
            return numbers;
        }

        static void SubSum(List<int> a, List<int> b)
        {
            
            
        }

        static void Calculate(string filename)
        {
            List<int>[] Numbers = GetTriangle(filename);
            int i = 0;
            do
            {
                SubSum(Numbers[i], Numbers[i + 1]);
            } while (i < Numbers.Length);

        }
    }
}
