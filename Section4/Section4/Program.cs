using System;
using System.Globalization;

namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Dados do produto: "+ p);
            Console.WriteLine("");
            Console.Write("Digite o número de produtos a ser adicionado em estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtde);
            Console.WriteLine("Dados atualizados: " + p);
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtde);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
