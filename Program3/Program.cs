using System;
using System.Globalization;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);
            // TESTE DE UTILIZAÇÃO DE COMENTÁRIOS
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdeQuartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
