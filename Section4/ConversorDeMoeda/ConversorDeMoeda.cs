using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double CalcularValor (double quantia, double cotacao)
        {
            return (Iof * quantia * cotacao) + (quantia *  cotacao);
        }
    }
}
