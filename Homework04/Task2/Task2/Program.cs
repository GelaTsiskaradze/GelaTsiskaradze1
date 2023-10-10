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
            char[] charArray = GetArray();
            (char searchChar, int count) = GetChar(charArray);
            PrintCharCount(searchChar, count);
            Console.ReadLine(); // Konsli rom ar daixuros
        }
        static char[] GetArray()
        {
            Console.Write("Miutitet Masivis zoma: ");
            int size = int.Parse(Console.ReadLine());

            char[] charArray = new char[size];

            Console.Write($"Daweret masivis {size}-ve elementi miyolebit: ");
            string input = Console.ReadLine();

            if (input.Length != size)
            {
                Console.WriteLine($"Masivi unda moicavdes zustad {size} simbolos.");
                return GetArray();
            }

            for (int i = 0; i < size; i++)
            {
                charArray[i] = input[i];
            }

            return charArray;
        }
        static (char, int) GetChar(char[] charArray)
        {
            Console.Write("Sheiyvanet sadziebo simbolo: ");
            char inputChar = char.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == inputChar)
                {
                    count++;
                }
            }

            return (inputChar, count);
        }
        static void PrintCharCount(char inputChar, int count)
        {
            Console.WriteLine($"Simbolo '{inputChar}' shegvxvda {count} jer.");
        }
    }
}