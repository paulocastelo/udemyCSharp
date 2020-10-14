using ECommerce.Entities;
using ECommerce.Entities.Enums;
using System;
using System.Globalization;

namespace ECommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----------------+");
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------+");
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int p = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateTime);
            Order order = new Order(DateTime.Now, orderStatus, client);


            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product, quantity, price);

                order.addItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine("Do you wish remove some item? (Y/N) ");
            char r = char.Parse(Console.ReadLine().ToUpper());
            if (r == 'Y')
            {
                Console.WriteLine("Insert item to delete: ");
            }

            Console.WriteLine(order.ToString());
        }
    }
}
