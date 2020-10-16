using System;
using System.Globalization;

namespace Aluno
{
    class AlunoProgram
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(a.Situacao());
        }
    }
}
