using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaximumPathSumOne
{
    class Triangle
    {
        public List<int>[] Numbers;

        public Triangle(List<int>[] n)
        {
            Numbers = n;
        }

        public static Triangle[] MakeSubTriangle(Triangle t)
        {
            int size = t.Numbers.Count() - 1;
            List<int>[] newNumbersLeft = new List<int>[size];
            List<int>[] newNumbersRight = new List<int>[size];

            for (int i = 0; i < size; i++)
            {
                List<int> newTriangleLine = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    newTriangleLine.Add(t.Numbers[i + 1][j]);
                }
                newNumbersLeft[i] = newTriangleLine;
            }

            for (int i = 0; i < size; i++)
            {
                List<int> newTriangleLine = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    newTriangleLine.Add(t.Numbers[i + 1][j + 1]);
                }
                newNumbersRight[i] = newTriangleLine;
            }
            return new Triangle[2] { new Triangle(newNumbersLeft), new Triangle(newNumbersRight) };
        }

        public static List<int>[] GetTriangle(string filename)
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

        public static int CalculateSum(Triangle t)
        {
            if (t.Numbers.Count() == 2)
            {
                int sum1 = t.Numbers[0][0] + t.Numbers[1][0];
                int sum2 = t.Numbers[0][0] + t.Numbers[1][1];
                return (sum1 > sum2) ? sum1 : sum2;
            }
            else
            {
                int subsum = 0;
                List<int> allSums = new List<int>();
                while (t.Numbers.Count() > 2)
                {
                    Triangle[] subTriangles = MakeSubTriangle(t);
                    foreach (var st in subTriangles)
                    {
                        subsum = CalculateSum(st);
                        allSums.Add(subsum);
                    }
                    int subsumleft = 0;
                    int subsumright = 0;
                    for (int i = 0; i < t.Numbers.Count(); i++)
                    {
                        subsumleft += t.Numbers[i][0];
                        subsumright += t.Numbers[i][t.Numbers[i].Count - 1];
                    }
                    allSums.Add(subsumleft);
                    allSums.Add(subsumright);
                    subsum=allSums.Max();
                }
                return subsum;
            }
        }
    }
}
