using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.CalcularValor(quantia,cotacao).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
