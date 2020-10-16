using ECommerce.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ECommerce.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder summary = new StringBuilder();
            summary.Append("ORDER SUMMARY:");
            summary.Append("\nOrder moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            summary.Append("\nOrder status: " + Status);
            summary.Append(Client.ToString());
            summary.Append("\nOrder items:");
            foreach (OrderItem item in Items)
            {
                summary.Append(item.ToString());
                Console.WriteLine();
            }

            summary.Append("\nTotal Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return summary.ToString();
        }
    }
}
