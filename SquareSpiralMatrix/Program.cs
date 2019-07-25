using System;

namespace SquareSpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(GenerateSpiralMatrix(n));
        }

        private static int[,] GenerateSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = n - 1;
            int stepsCount = n;
            int stepsDone = 1;
            int stepChange = 1;
            int direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                //Console.WriteLine("Matrix: {0}, {1}", row, col);
                // Fill the current cell
                matrix[row, col] = i;

                // Check for direction change
                if (stepsDone < stepsCount)
                {
                    stepsDone++;
                }
                else
                {
                    stepsDone = 1;
                    if (stepChange == 1)
                    {
                        stepsCount--;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }

                // Move to the next cell
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
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
