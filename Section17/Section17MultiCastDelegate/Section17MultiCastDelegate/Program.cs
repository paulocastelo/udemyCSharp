using System;
using Section17MultiCastDelegate.Services;

namespace Section17MultiCastDelegate
{
    delegate void BinaryNuericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNuericOperation op = CalculationServices.ShowMax;
            op += CalculationServices.ShowSum;
            op(a, b);
        }
    }
}
