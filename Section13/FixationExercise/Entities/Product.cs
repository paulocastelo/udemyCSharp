using System.Globalization;
using System.Text;

namespace FixationExercise.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public Product() { }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double TotalPrice()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Name + ", " + TotalPrice().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
