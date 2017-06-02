using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle:Shape
    {
        public double Width { get;protected set; }
        public double Height { get; protected set; }

        public Rectangle()
        {
            Console.WriteLine($"Rectangle's default constructor");
        }
        public Rectangle(double w,double h)
        {
            this.Width = w;
            this.Height = h;
        }

        public override double Area
        {
            get {
                return this.Width * this.Height;
            }

        }
        public override void Draw()
        {
            Console.WriteLine($"This is derived class Rectangle Draw");
        }
    }
}
