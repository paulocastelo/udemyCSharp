using System;

namespace MatrizesResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size for matriz: ");
            int n = int.Parse(Console.ReadLine());

            //COUNT ALL NEGATIVE OCCURENCE
            int negative = 0;

            //MATRIX DECLARATION
            int[,] intMatrix = new int[n, n];

            //VECTOR WITH NUMBERS FROM DIAGONALS
            int[] vectDiagonal = new int[n];

            for (int i = 0; i < n; i++)
            {
                //SPLITS ALL BLANK SPACES
                string[] stringInsert = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    intMatrix[i, j] = int.Parse(stringInsert[j]);
                    if (intMatrix[i, j] < 0)
                    {
                        negative += 1;
                    }
                    if (i == j)
                    {
                        vectDiagonal[j] = intMatrix[i, j];
                    }
                }
            }

            string stDiagonal = "";

            foreach (int item in vectDiagonal)
            {
                stDiagonal += " " + item;
            }

            Console.WriteLine("Main diagonal: " + stDiagonal);

            //FORMA MAIS SIMPLES
            Console.Write("Main diagonal SIMPLES: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(intMatrix[i, i] + " ");
            }

            Console.WriteLine("Negative numbers: " + negative);
            Console.WriteLine("");
            //OUTRA FORMA
            int negative2 = 0;
            Console.Write("Negative numbers 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(intMatrix[i,j] < 0)
                    {
                        negative2++;
                    }
                }
            }

            Console.Write(negative2);
        }
    }
}
