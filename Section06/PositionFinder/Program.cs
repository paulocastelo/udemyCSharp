using System;
using System.Net.WebSockets;

namespace PositionFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert dimensions for matrix: ");
            Console.Write("Rows: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            int n = int.Parse(Console.ReadLine());

            //FULLFILL THE MATRIX
            int[,] intMatrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    intMatrix[i, j] = int.Parse(vect[j]);
                }
            }
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("");

            //PRINT ALL ELEMENTS FROM MATRIX
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(intMatrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("");

            Console.Write("Insert number to find: ");
            int match = int.Parse(Console.ReadLine());
            //PRINT ALL MATCHES AT MATRIX
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (intMatrix[i, j] == match)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + intMatrix[i, j - 1]);
                        }
                        if (j + 1 < n)
                        {
                            Console.WriteLine("Right: " + intMatrix[i, j + 1]);
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + intMatrix[i - 1, j]);

                        }
                        if (i + 1 < m)
                        {
                            Console.WriteLine("Down: " + intMatrix[i + 1, j]);

                        }
                    }
                }
                Console.WriteLine("");
            }

        }

    }
}
