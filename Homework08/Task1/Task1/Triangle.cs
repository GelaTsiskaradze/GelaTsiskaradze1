using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Aseti samkutxedi ar arsebobs, Sheiyvanet gverdebi sworad!");
            }

            sideA = a;
            sideB = b;
            sideC = c;
        }

        public double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.GetArea() == t2.GetArea();
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return t1.GetArea() != t2.GetArea();
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            return t1.GetArea() > t2.GetArea();
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.GetArea() < t2.GetArea();
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            double a = Math.Sqrt(t1.GetArea() + t2.GetArea());
            return new Triangle(a, a, Math.Sqrt(2) * a);
        }

        public static explicit operator Triangle(double sideLength)
        {
            return new Triangle(sideLength, sideLength, sideLength);
        }
    }
}