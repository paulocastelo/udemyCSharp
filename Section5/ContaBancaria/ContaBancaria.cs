using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaBancaria
    {
        Titular Titular = new Titular("Novo usuário");

        public int Numero { get; set; }

        public double Saldo { get; private set; }


        private double _taxa = 5.00;

        public ContaBancaria(string nome, int numero)
        {
            Titular.Nome = nome;
            Numero = numero;
        }
        public ContaBancaria(string nome, int numero, double saldo) : this(nome, numero)
        {
            Saldo = saldo;
        }
        

        public void Deposita(double depositoInicial)
        {
            if(depositoInicial > 0)
            {
                Deposita(depositoInicial);
            }
        }

        public void Saque (double valorSaque)
        {
            if (valorSaque > 0)
            {
                Saldo -= (valorSaque + _taxa);
            }
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                    ", Titular: " + Titular.Nome +
                    ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture)
                ;
        }
    }
}
