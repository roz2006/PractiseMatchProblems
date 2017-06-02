using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        //public new double Width { get; private set; }
        //public Square(double w):base(w,w)
        //{

        //}
        public Square()
        {
            Console.WriteLine("Square's default constructor sets width to 13");
            this.Height = 13;
            this.Width = 13;
        }

        public Square(double v) : base(v, v) { }



        public override double Area
        {
            get
            {
                return Width * Width;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"This is derived class Square Draw");
        }
    }
}
