using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] firstMatrix = new double[3, 3];

            Console.WriteLine(firstMatrix.Length);

            Console.WriteLine(firstMatrix.Rank);

            Console.WriteLine(firstMatrix.GetLength(0)); //PRINT FIRST DIMENSION, LINES

            Console.WriteLine(firstMatrix.GetLength(1)); //PRINT SECOND DIMENSION, COLUMNS
        }
    }
}
