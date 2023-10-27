using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculatori");
            Console.WriteLine("Ricxvi 1: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Ricxvi 2: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($"{num1} + {num2} = {Calculator.Add(num1, num2)}");
                    Console.WriteLine($"{num1} - {num2} = {Calculator.Subtract(num1, num2)}");
                    Console.WriteLine($"{num1} * {num2} = {Calculator.Multiply(num1, num2)}");

                    try
                    {
                        Console.WriteLine($"{num1} / {num2} = {Calculator.Divide(num1, num2)}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Sheiyvanet ricxvi sworad.");
                }
            }
            else
            {
                Console.WriteLine("Sheiyvanet ricxvi sworad.");
            }
        }
    }
}