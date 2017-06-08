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
        static void Main(string[] args)
        {
            string filename = @"c:\temp\triangle.txt";
            Triangle t = new Triangle(Triangle.GetTriangle(filename));
            Triangle.CalculateSum(t);
        }
    }
}

