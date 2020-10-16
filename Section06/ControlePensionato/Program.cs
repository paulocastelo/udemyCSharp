using System;
using System.Globalization;

namespace ControlePensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number of rents: ");
            int n = int.Parse(Console.ReadLine());

            Room[] vect = new Room[10];

            for (int i = 0; i < 10; i++)
            {
                vect[i] = new Room();
                vect[i].Empty = true;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.Write("Insert a name for student [" + i + "]: ");
                string nome = Console.ReadLine();
                Console.Write("Insert an e-mail for student [" + i + "]: ");
                string email = Console.ReadLine();
                Console.Write("Insert selected room for student [" + i + "]: ");
                int room = int.Parse(Console.ReadLine());
                while (vect[room].Empty == false)
                {
                    if(vect[room].Empty == false)
                    {
                        Console.Write("This room is not empty, please choose another one: ");
                        room = int.Parse(Console.ReadLine());
                    }
                }
                vect[room].aluno = new Aluno();
                vect[room].aluno.Nome = nome;
                vect[room].aluno.Email = email;
                vect[room].aluno.Quarto = room;
                vect[room].Empty = false;
            }
            Console.WriteLine("");
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i].Empty != true)
                {
                    Console.WriteLine(vect[i].aluno.Quarto + ": " + vect[i].aluno.Nome + ", e-mail: " + vect[i].aluno.Email);
                }
            }

        }
    }
}
