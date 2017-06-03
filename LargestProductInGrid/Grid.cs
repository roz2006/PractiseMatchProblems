using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LargestProductInGrid
{
    class Grid
    {
        public enum Dimension { Horizontal, Vertical, Diagonal, DiagonalReverse };
        public int Width { get; set; }
        private int[] Numbers;
        public Grid(int w)
        {
            Width = w;
            Numbers = new int[Width * Width];
        }

        public void FillGrid(string filename)
        {
            string alltexts = File.ReadAllText(filename);
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
                    { Numbers[j] = int.Parse(number); j++; }
                    counter++;
                } while (counter < bits.Length);
            }
            catch (Exception)
            {

                Console.WriteLine("Error occured");
            }
        }

        static int Calculate(int[,] grid)
        {
            int product = 0;

            //Calculate products

            return product;
        }

        public List<int[]> GetIndex(int length, Dimension d)
        {
            List<int[]> indexList = new List<int[]>();
            //int[] indice = new int[length];
            switch (d)
            {
                case Dimension.Horizontal:
                    for (int r = 0; r < Width; r++)
                    {
                        for (int i = 0; i < Width - length + 1; i++)
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
                    for (int c = 0; c < Width; c++)
                    {
                        for (int i = 0; i < Width - length + 1; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[j] = c + i * 20 + j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;
                case Dimension.Diagonal:
                    for (int r = 0; r < Width - length + 1; r++)
                    {
                        for (int i = 0; i < Width - length + 1; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[j] = r * 20 + i + j * 20 + j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;
                case Dimension.DiagonalReverse:
                    for (int r = 0; r < Width - length + 1; r++)
                    {
                        for (int i = length - 1; i < Width; i++)
                        {
                            int[] indice = new int[length];
                            for (int j = 0; j < length; j++)
                            {
                                indice[j] = r * 20 + i + j * 20 - j;
                            }
                            indexList.Add(indice);
                        }
                    }
                    break;
                default:
                    break;
            }
            return indexList;
        }

        public void Print()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(Numbers[i * Width + j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int MaxProduct(List<int[]> indices)
        {
            int maxproduct = 0;

            foreach (int[] item in indices)
            {
                int product = Numbers[item[0]];
                for (int i = 1; i < item.Length; i++)
                {
                    product *= Numbers[item[i]];
                }
                if (product > maxproduct)
                    maxproduct = product;
            }
            return maxproduct;
        }

        public int Calcualte(int length)
        {
            int max = 0;
            foreach (Dimension item in Enum.GetValues(typeof(Dimension)))
            {
                int submax = MaxProduct(GetIndex(length, item));
                if (submax > max)
                    max = submax;

            }
            return max;
        }
    }
}
