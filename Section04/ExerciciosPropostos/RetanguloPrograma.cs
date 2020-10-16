using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class RetanguloPrograma
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);
        }
    }
}
