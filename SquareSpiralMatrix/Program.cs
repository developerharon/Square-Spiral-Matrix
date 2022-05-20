using System;

namespace SquareSpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program prints an n by n matrix.");
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            var nByNMatrix = Matrix.GenerateSpiralMatrix(n);
            Matrix.PrintMatrix(nByNMatrix);
        }
    }
}
