using System;
using System.Globalization;

namespace Exercicio
{
    class Program2
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'F';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é R$ {1}.", produto1, preco1);
            Console.WriteLine("{0}, cujo o preço é R$ {1}.", produto2, preco2);
            Console.WriteLine("--------");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é R$ {preco1}.");
            Console.WriteLine($"{produto2}, cujo o preço é R$ {preco2}.");
            Console.WriteLine("--------");
            Console.WriteLine(produto1 + ", cujo o preço é R$ " + preco1.ToString("F2",CultureInfo.InvariantCulture)+ ".");
            Console.WriteLine(produto2 + ", cujo o preço é R$ " + preco2.ToString("F2",CultureInfo.InvariantCulture)+ ".");
            Console.WriteLine("--------");
            Console.WriteLine("Medida com oito casa decimais : "+medida.ToString("F8"));
            Console.WriteLine("Arrendodando (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Arrendodando (três casas decimais): " + medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
