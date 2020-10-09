using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura * Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));

        }

        public override string ToString()
        {
            return "Dados do retângulo: \nAltura: " + Altura.ToString("F2",CultureInfo.InvariantCulture) +
                    "\nLargura: "+ Largura.ToString("F2", CultureInfo.InvariantCulture) +
                    "\nArea: " + Area().ToString("F2", CultureInfo.InvariantCulture) +
                    "\nPerimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) +
                    "\nDiagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
