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

        public Triangle[] MakeSubTriangle(Triangle t)
        {
            int size = t.Numbers.Count() - 1;
            List<int>[] newNumbers = new List<int>[size];


        }

        static void GetTriangle(string filename)
        {
            string[] alllines = System.IO.File.ReadAllLines(filename);
            List<int>[] Numbers = new List<int>[alllines.Length];
            Regex regex = new Regex(@"\s");
            for (int i = 0; i < alllines.Length; i++)
            {
                string[] bits = regex.Split(alllines[i]);
                List<int> l = new List<int>();
                foreach (string bit in bits)
                {
                    l.Add(int.Parse(bit));
                }
                Numbers[i] = l;
            }
        }

        static void SubMaxSum(List<int> a, List<int> b)
        {
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (sum < a[i] + b[i])
                    sum = a[i] + b[i];
                if (sum < a[i] + b[i + 1])
                    sum = a[i] + b[i + 1];
            }
        }

        static int Calculate()
        {
            int i = 0;
            int sum = Numbers[i][0];
            do
            {
                if (Numbers[i] Numbers[i + 1].Max;
                SubMaxSum(Numbers[i], Numbers[i + 1]);
            } while (i < Numbers.Length);

            return sum;
        }
    }
}
