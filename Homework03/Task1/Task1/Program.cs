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
            Console.Write("Sheiyvanet masivis zoma (N): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Mxolod Naturaluri Ricxvebi.");
                return;
            }

            int[] array = new int[n];

            // masivi
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Masivis {i + 1} elementi: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Sortirebis algoriTmi
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //elementebis gadanacvleba
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Zrdadobit dalagebuli elementebi:");
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }

            Console.ReadLine(); // es chavsvi imisatvis rom konsoli ar daixuros
        }
    }
}