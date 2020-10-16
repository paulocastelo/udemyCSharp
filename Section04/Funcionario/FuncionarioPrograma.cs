using System;
using System.Globalization;

namespace ExerciciosPropostos
{
    class FuncionarioPrograma
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + f.Nome + ", salário líquido: " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite a procentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);

            Console.WriteLine(f);
        }
    }
}
