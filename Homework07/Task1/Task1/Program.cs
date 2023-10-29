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
            Console.WriteLine("Airchiet figura:");
            Console.WriteLine("1 - Samkutxedi");
            Console.WriteLine("2 - Martkutxedi");
            Console.WriteLine("3 - Wre");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Chaweret gverdi a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Sheiyvanet gverdi b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Sheiyvanet gverdi c: ");
                double c = double.Parse(Console.ReadLine());

                try
                {
                    Triangle triangle = new Triangle(a, b, c);
                    Console.WriteLine($"Perimeteri: {triangle.Perimeter()}");
                    Console.WriteLine($"Fartobi: {triangle.Area()}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Sheiyvanet sigane: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Sheiyvanet simagle: ");
                double height = double.Parse(Console.ReadLine());

                try
                {
                    Rectangle rectangle = new Rectangle(width, height);
                    Console.WriteLine($"Perimeteri: {rectangle.Perimeter()}");
                    Console.WriteLine($"Fartobi: {rectangle.Area()}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Chaweret wris radiusi: ");
                double radius = double.Parse(Console.ReadLine());

                try
                {
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"Perimeteri: {circle.Perimeter()}");
                    Console.WriteLine($"Fartobi: {circle.Area()}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Chaweret 1, 2 an 3.");
            }
        }
    }
}