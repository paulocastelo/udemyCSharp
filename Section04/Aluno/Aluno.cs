using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml;

namespace Aluno
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;
        public double NotaTotal;

        public double NotaFinal()
        {
            NotaTotal = N1 + N2 + N3;
            return NotaTotal;
        }

        public string Situacao()
        {
            if (NotaTotal >= 60)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado\nFaltaram " + (60 - NotaTotal).ToString("F2",CultureInfo.InvariantCulture) + " pontos.";
            }
        }
    }
}
