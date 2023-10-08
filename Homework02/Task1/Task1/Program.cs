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
            Random random = new Random();
            int randomNum = random.Next(1, 10);
            int numberOfGuesses = 3;

            Console.WriteLine("მოგესალმები, მე ჩავიფიქრე რიცხვი 1-დან 10-მდე!");
            Console.WriteLine("ეცადე გამოიცნო, 3 ცდა გაქვს!");

            for (int i = 0; i < numberOfGuesses; i++)
            {
                Console.Write($"ცდა {i + 1} - ლი: ");

                int userNum = int.Parse(Console.ReadLine());

                if (userNum == randomNum)
                {
                    Console.WriteLine($"გილოცავ! შენ სწორად გამოიცანი რიცხვი: {randomNum}");
                    return;
                }
                else
                {
                    Console.WriteLine("ვერ გამოიცანი, კიდევ სცადე");
                }
            }

            Console.WriteLine($"სამწუხაროდ შენ ვერ გამოიცანი, სწორი რიცხვი იყო: {randomNum}");
        }
    }
}
