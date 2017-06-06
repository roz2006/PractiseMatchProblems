using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LatticePaths
{
    class Lattice
    {
        private int Width;
        public BigInteger Counter = new BigInteger();

        public Lattice(int width)
        {
            Width = width;
            Counter = 0;
        }

        public void Travers(int x, int y)
        {
            if (x < Width)
                Travers(x + 1, y);
            if (y < Width)
                Travers(x, y + 1);
            if (x == Width && y == Width)
                 Counter++;
        }
    }
}
