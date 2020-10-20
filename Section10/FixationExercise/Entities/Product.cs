using System.Globalization;
using System.Text;

namespace FixationExercise.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append(" $" + Price.ToString("F2", CultureInfo.InvariantCulture));
            return s.ToString();
        }
    }
}
