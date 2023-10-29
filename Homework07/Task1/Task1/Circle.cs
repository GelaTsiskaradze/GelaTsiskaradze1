using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Mocemuli wris radiusi arasworia.");
            }

            radius = r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
