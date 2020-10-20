using System.Globalization;
using System.Text;

namespace FixationExercise.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct (string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
            Price = price;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append(" $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            s.Append(" (Customs fee: $" + CustomFee.ToString("F2",CultureInfo.InvariantCulture) + ")");
            return s.ToString();
        }
    }
}
