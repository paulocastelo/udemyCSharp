using System;
using System.Globalization;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            string nome = "Maria";
            int idade = 32;
            double saldo = 10.3546;

            Console.WriteLine("Exemplo de utilização de PlaceHolder.");
            Console.WriteLine("{0} tem {1} anos e {2:F2} reais de saldo.", nome,idade,saldo);
            Console.WriteLine("-------------------");
            Console.WriteLine("Exemplo de utilização de Interpolação.");
            Console.WriteLine($"{nome} tem {idade} e {saldo:F2} reais de saldo.");
            Console.WriteLine("-------------------");
            Console.WriteLine("Exemplo de utilização de Concatenação.");
            Console.WriteLine(nome + " tem " + idade + " e " +(saldo.ToString("F2",CultureInfo.InvariantCulture))+" reais de saldo.");
            Console.WriteLine("-------------------");
            Console.WriteLine("Bom dia.");
            Console.Write("Boa tarde.");
            Console.WriteLine("Boa noite.");
            Console.WriteLine("-------------------");
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
