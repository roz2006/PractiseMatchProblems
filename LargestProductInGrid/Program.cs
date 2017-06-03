using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace LargestProductInGrid
{
    class Program
    {
        const int width = 20; // Width of the square grid



        static void Main(string[] args)
        {
            string filename = @"C:\Users\roz\Documents\grid.txt";
            Grid myGrid = new Grid(20);
            myGrid.FillGrid(filename);

            //myGrid.Print();

            //List<int[]> index_h = myGrid.GetIndex(4, Grid.Dimension.Horizontal);
            //List<int[]> index_v = myGrid.GetIndex(4, Grid.Dimension.Vertical);
            //List<int[]> index_d = myGrid.GetIndex(4, Grid.Dimension.Diagonal);
            //List<int[]> index_dr = myGrid.GetIndex(4, Grid.Dimension.DiagonalReverse);

            Console.WriteLine(myGrid.Calcualte(4));
        }
    }
}
