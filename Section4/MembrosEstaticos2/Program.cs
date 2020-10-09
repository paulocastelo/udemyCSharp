using System;
using System.Globalization;

namespace MembrosEstaticos2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Colume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
