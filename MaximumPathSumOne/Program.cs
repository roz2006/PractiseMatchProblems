using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaximumPathSumOne
{
    class Program
    {
        static int sum = 0;
        private static int length;

        static void Main(string[] args)
        {
            string filename = @"c:\temp\triangle.txt";
            Calculate(filename);
        }
    }
}

