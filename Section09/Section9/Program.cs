using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of orders: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("There is no orders!");
            }
            else
            {
                Order[] order = new Order[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Number for order[" + i + "]");
                    order[i] = new Order();
                    order[i].Id = 100 + i;
                    order[i].Moment = DateTime.Now;
                    Console.WriteLine("Set status for order:");
                    order[i].Status = (OrderStatus)int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("+--------------------+");
                    Console.WriteLine(order[i]);
                    Console.WriteLine("+--------------------+");
                }
            }

            Order exemplo = new Order
            {
                Id = n + 10,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            
            Console.WriteLine(exemplo);

            Console.Write("Cast String to OrderStatus: ");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            Console.Write("Enum to String: ");
            OrderStatus os = Enum.Parse<OrderStatus>("PendingPayment");
            Console.WriteLine(os);


        }
    }
}
