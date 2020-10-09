using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +
                    "\nSalario Bruto: " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture) +
                    "\nImposto: " + Imposto.ToString("F2", CultureInfo.InvariantCulture) +
                    "\nSalario Líquido: " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
