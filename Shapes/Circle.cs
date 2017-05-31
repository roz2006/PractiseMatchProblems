using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius { get; protected set; }

        public Circle(double r)
        {
            this.Radius = r;
        }

        public override double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }

        }

    }
}
