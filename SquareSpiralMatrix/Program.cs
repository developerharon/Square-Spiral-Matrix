using System;

namespace SquareSpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMatrix(GenerateSpiralMatrix(3));
        }

        private static int[,] GenerateSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = n - 1;
            int stepsCount = 0;
            int direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                // Fill the current cell
                matrix[row, col] = i;

                // Check for direction change
                if (stepsCount == 2)
                {
                    stepsCount = 0;
                    direction = (direction + 1) % 4;
                } else
                {
                    stepsCount++;
                }

                switch(direction)
                {
                    case 0: row++; break;
                    case 1: col--; break;
                    case 2: row--; break;
                    case 3: col++; break;
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
