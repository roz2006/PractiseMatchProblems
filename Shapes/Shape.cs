using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        abstract public double Area{get;}

        public virtual void Draw()
        {
            Console.WriteLine($"This is Base class Shape Draw");
        }
    }
}
