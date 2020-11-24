using System;
using System.Collections.Generic;

namespace S14FixationExercises.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments;
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
