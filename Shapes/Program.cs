using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq1 = new Square();
            //Console.WriteLine(c.Area);

            Rectangle r1 = new Rectangle();
            r1.Draw();

            Shape s1 = (Shape)r1;
            s1.Draw();

            Circle c1 = new Circle(5);
            c1.Draw();

            Shape s2 = sq1 as Shape;

            if (s2 is Square)
                Console.WriteLine("second shape is a square");
                
            if(s2 is Shape)
                Console.WriteLine("Second shape is a shape");
        }
    }
}
