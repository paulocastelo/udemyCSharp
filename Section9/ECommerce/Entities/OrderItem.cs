
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ECommerce.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity, double price)
        {
            Item = product;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder orderItensSummary = new StringBuilder();
            orderItensSummary.Append("\n" + Item.Name + ", $" +
                                    Item.Price.ToString("F2", CultureInfo.InvariantCulture) +
                                    ", Quantity: " + Quantity + ", Subtotal: $" +
                                    SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return orderItensSummary.ToString();
        }
    }
}
