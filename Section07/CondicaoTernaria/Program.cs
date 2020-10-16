using System;
using System.Globalization;

namespace CondicaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a value for product price: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto, precoFinal;
            char repeat = 'N';
            bool final = true;

            //USING STANDARD CONDITIONAL STRUCTURE
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
                precoFinal = preco - desconto;
            }
            else
            {
                desconto = preco * 0.05;
                precoFinal = preco - desconto;
            }
            Console.WriteLine("PREÇO DO PRODUTO: "+preco);
            Console.WriteLine("DESCONTO: "+desconto);
            Console.WriteLine("PREÇO FINAL: "+precoFinal);

            Console.Write("DO YOU WISH PROCEED AGAIN? Y/N");
            repeat = char.Parse(Console.ReadLine());
            final = (repeat == 'Y') ? true : false;

            if(final == false)
            {
                Console.WriteLine("PROGRAM FINISHED!");
            }
            else
            {
                Console.Write("Insert a value for product price: ");
                preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //USING TERNARY OPERATOR
                desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
                precoFinal = preco - desconto;

                Console.WriteLine("PREÇO DO PRODUTO: " + preco);
                Console.WriteLine("DESCONTO: " + desconto);
                Console.WriteLine("PREÇO FINAL: " + precoFinal);
            }
        }
    }
}
