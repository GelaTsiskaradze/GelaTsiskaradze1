using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Shape
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            if (w <= 0 || h <= 0)
            {
                throw new ArgumentException("Mocemuli martkutxedis gverdebi arasworia.");
            }

            width = w;
            height = h;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
