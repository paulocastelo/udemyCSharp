using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta = 0;
            string titular;
            double valor = 0.00;
            char depositoInicial = 'n';

            Console.Write("Entre o número do conta: ");
            numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o nome do titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoInicial = char.Parse(Console.ReadLine());

            ContaBancaria conta;


            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titular, numeroConta, valor);
            }
            else {
                conta = new ContaBancaria(titular, numeroConta);
            }
            
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine("");

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposita(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
