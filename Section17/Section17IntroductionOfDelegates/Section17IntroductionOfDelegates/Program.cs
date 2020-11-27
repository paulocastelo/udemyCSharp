using System;
using Section17IntroductionOfDelegates.Services;

namespace Section17IntroductionOfDelegates
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
        delegate double NumericOperation(double n1);
        static void Main(string[] args)
        {
            //Block with no using of DELEGATE
            double a = 10;
            double b = 12;
            double sum1 = CalculationService.Sum(a, b);
            double max1 = CalculationService.Max(a, b);
            double sqr1 = CalculationService.Square(a);
            double sqr2 = CalculationService.Square(b);
            Console.WriteLine("Sum with no DELEGATE: " + sum1);
            Console.WriteLine("Max with no DELEGATE: " + max1);
            Console.WriteLine("First square with no DELEGATE: " + sqr1);
            Console.WriteLine("Second square with no DELEGATE: " + sqr2); Console.WriteLine();

            //Block with using of DELEGATE
            NumericOperation sqr3 = CalculationService.Square;
            BinaryNumericOperation sum = CalculationService.Sum;
            BinaryNumericOperation max2 = CalculationService.Max;
            //BinaryNumericOperation 
            Console.WriteLine("Sum with DELEGATE: " + sum(a, b));
            Console.WriteLine("Max with DELEGATE: " + max2(a, b));
            Console.WriteLine("Square 1 with DELEGATE: " + sqr3(a));
            Console.WriteLine("Square 2 with DELEGATE: " + sqr3(b));

        }
    }
}
