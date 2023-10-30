using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Chaweret I samkutxedis gverdis sigrZeebi:");
                double a1 = double.Parse(Console.ReadLine());
                double b1 = double.Parse(Console.ReadLine());
                double c1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Chaweret II samkutxedis gverdis sigrZeebi:");
                double a2 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());
                double c2 = double.Parse(Console.ReadLine());

                Triangle triangle1 = new Triangle(a1, b1, c1);
                Triangle triangle2 = new Triangle(a2, b2, c2);

                Console.WriteLine($"I samkutxedis Fartobi: {triangle1.GetArea()}");
                Console.WriteLine($"I samkutxedis Perimetri: {triangle1.GetPerimeter()}");
                Console.WriteLine($"II samkutxedis Fartobi: {triangle2.GetArea()}");
                Console.WriteLine($"II samkutxedis Perimetri: { triangle2.GetPerimeter()}");

                Console.WriteLine($"Samkutxedi I udris II: {triangle1 == triangle2}");
                Console.WriteLine($"Samkutxedi I ar udris II: {triangle1 != triangle2}");
                Console.WriteLine($"Samkutxedi I > II: {triangle1 > triangle2}");
                Console.WriteLine($"Samkutxedi I < II: {triangle1 < triangle2}");

                Console.WriteLine("Chaweret tolgverda samkutxedis gverdis sigrdze:");
                double sideLength = double.Parse(Console.ReadLine());
                Triangle equilateralTriangle = (Triangle)sideLength;
                Console.WriteLine($"Tolgverda samkutxedis Fartobi: {equilateralTriangle.GetArea()}");
                Console.WriteLine($"Tolgverda samkutxedis Perimetri: {equilateralTriangle.GetPerimeter()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}