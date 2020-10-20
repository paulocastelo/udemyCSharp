using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProposedExercises2.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public TaxPayer() { }
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append(", anual income: $" + AnualIncome.ToString("F2", CultureInfo.InvariantCulture));
            s.Append(", total tax: $" + Tax().ToString("F2", CultureInfo.InvariantCulture));
            return s.ToString();
        }
    }
}
