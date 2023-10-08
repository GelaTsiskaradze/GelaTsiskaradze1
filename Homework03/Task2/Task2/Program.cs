using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pirveli Arrays inputi
            Console.Write("Pirveli masivis elementebis raodenoba (N): ");
            int n = int.Parse(Console.ReadLine());
            string[] array1 = new string[n];

            Console.WriteLine("Sheviyvanot masivis elementebi:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementi {i + 1}: ");
                array1[i] = Console.ReadLine();
            }

            // meore Arrays inputi
            Console.Write("Meore array-s elementebis raodenoba: ");
            int m = int.Parse(Console.ReadLine());
            string[] array2 = new string[m];

            Console.WriteLine("Sheviyvanot masivis elementebi:");
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Elementi {i + 1}: ");
                array2[i] = Console.ReadLine();
            }

            // ori arrays gaertianebis funqcia (amis dawerashi damexmarnen)
            string[] concatenatedArray = new string[n + m];
            for (int i = 0; i < n; i++)
            {
                concatenatedArray[i * 2] = array1[i];
                concatenatedArray[i * 2 + 1] = array2[i % m];
            }

            // gaertianebuli Arrays gamotana
            Console.WriteLine("\nConcatenated Array:");
            foreach (string element in concatenatedArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine(); // es chavsvi imisatvis rom konsoli ar daixuros
        }
    }
}
