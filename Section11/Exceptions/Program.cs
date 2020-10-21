using System;

namespace ExceptionsTryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert a number: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Insert another number: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Format error! "+ f.Message);
            }
            finally
            {
                Console.WriteLine("Command block execute anyway!");
            }
        }
    }
}
