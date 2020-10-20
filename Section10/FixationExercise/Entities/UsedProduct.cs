using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FixationExercise.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDare { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDare = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append("(used) $" + Price.ToString("F2", CultureInfo.InvariantCulture));
            s.Append(" (Manufacture date: " + ManufactureDare.ToString("dd/MM/YYYY") + ")");
            return s.ToString();
        }
    }
}
