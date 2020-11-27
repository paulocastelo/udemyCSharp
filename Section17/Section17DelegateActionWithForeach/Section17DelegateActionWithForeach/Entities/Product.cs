using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Section17DelegateActionWithForeach.Entities
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("The object is not a product.");
            }
            Product other = obj as Product;
            return Name.ToUpper().Equals(other.Name.ToUpper());
        }
        public int CompareTo(Product other)
        {
            if (!(other is Product))
            {
                throw new ArgumentException("The object is not a product.");
            }
            Product p = other as Product;
            return Name.ToUpper().CompareTo(p.Name.ToUpper());
        }
    }
}

