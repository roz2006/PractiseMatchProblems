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

        enum Dimension { Horizontal, Vertical, Diagonal, DiagonalReverse };

        static void Main(string[] args)
        {
            string filename = @"C:\Users\roz\Documents\grid.txt";
            int[] numbers = Getgrid(filename);

            List<int[]> indices;
            indices = GetIndex(4, Dimension.Horizontal);

        }

        /// <summary>
        /// Read from the file and construct the grid of numbers
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>A square of numbers</returns>
        static int[] Getgrid(string filename)
        {
            int[] array = new int[width * width];
            string alltexts = File.ReadAllText(filename);
            //string[] alltexts = File.ReadAllLines(filename);
            try
            {
                Regex regex = new Regex(@"\s");
                string[] bits = regex.Split(alltexts);
                int j = 0;
                int counter = 0;
                do
                {
                    string number = bits[counter].Trim();
                    if (!number.Equals(""))
                    { array[j] = int.Parse(number); j++; }
                    counter++;
                } while (counter < bits.Length);
            }
            catch (Exception)
            {

                Console.WriteLine("Error occured");
            }
            return array;
        }

        static int Calculate(int[,] grid)
        {
            int product = 0;
            if ((grid.GetLength(0) != width) || (grid.GetLength(1) != width))
            { Console.WriteLine("The grid is not complete"); return 0; }

            //Calculate products

            return product;
        }

        /// <summary>
        /// Based on which dimension, return indices of the grid.
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Dimension"></param>
        /// <returns></returns>
        static List<int[]> GetIndex(int length, Dimension d)
        {
            List<int[]> indexList = new List<int[]>();
            //int[] indice = new int[length];
            switch (d)
            {
                case Dimension.Horizontal:
                    for (int r = 0; r < width; r++)
                    {
                        for (int i = 0; i < width - length + 1; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[j] = r * 20 + i + j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;

                case Dimension.Vertical:
                    for (int c = 0; c < width; c++)
                    {
                        for (int i = 0; i < width - length + 1; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[i] = c + i * 20 + j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;
                case Dimension.Diagonal:
                    for (int r = 0; r < width; r++)
                    {
                        for (int i = 0; i < width - length + 1; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[i] = r * 20 + i + j * 20 + j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;
                case Dimension.DiagonalReverse:
                    for (int i = 0; i < width - length + 1; i++)
                    {
                        int[] indice = new int[length];
                        for (int j = 0; j < length; j++)
                        {
                            indice[j] = i + width - 1 + j * 20 - j;
                        }
                        indexList.Add(indice);
                    }
                    break;
                default:
                    break;
            }
            return indexList;
        }
    }
}
