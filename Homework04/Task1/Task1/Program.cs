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
            Console.Write("Sheiyvanet masivis zoma: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Elementi {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Sheiyvanet indeqsi: ");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= size)
            {
                Console.WriteLine("Sheiyvanet Validuri indeqsi");
                return;
            }

            int element = array[index];
            int sum = 0;

            // Dajamebis funqcia
            while (element != 0)
            {
                sum += element % 10;
                element /= 10;
            }

            Console.WriteLine($"Elementi {index} cifrta jami: {sum}");

            Console.ReadLine();
        }
    }
}
