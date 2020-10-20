using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProposedExercise.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append(" - $");
            s.Append(Payment().ToString("F2",CultureInfo.InvariantCulture));
            return s.ToString();
        }
    }
}
