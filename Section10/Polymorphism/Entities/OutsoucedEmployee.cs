using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercise.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = addionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
