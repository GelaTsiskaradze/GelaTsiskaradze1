using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SheiyvaneT matricis ganzomiebebi (2x2 an 3x3):");
            Console.Write("Rigebis raodenoba: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Svetebi raodenoba: ");
            int columns = int.Parse(Console.ReadLine());

            if (rows != columns || (rows != 2 && rows != 3))
            {
                Console.WriteLine("Mcdari ganzomilebebi, Sheiyvanet 2x2 an 3x3 matrica.");
                return;
            }

            double[,] matrix = new double[rows, columns];

            Console.WriteLine("Sheiyvanet matricis elementebi rigisa da svetis mixedvit:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Sheiyvanet {i + 1} rigis, {j + 1} svetis elementis mnishvneloba: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double determinant = CalcDet(matrix);

            // Gamoaqvs matrica.
            Console.WriteLine("Matrica:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Determinanti: {determinant}");

            Console.ReadLine(); // es chavsvi imisatvis rom konsoli ar daixuros.
        }

        // Determinantis gamotvlis algoriTmii
        static double CalcDet(double[,] matrix)
        {
            int n = matrix.GetLength(0); // igebs rigis(rows) mnishvnelobas.

            if (n == 2)
            {
                // Determinanti 2x2 matricistvis.
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else if (n == 3)
            {
                // Determinanti 3x3 matricistvis.
                return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                       matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                       matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
            }

            return 0; // imshemtxvevashi tuki matrica ar aris kvadratuli.
        }
    }
}
