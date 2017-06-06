using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerablePractice
{
    class Car: IEnumerable
    {
        public string Color;
        public int Year;

        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
