namespace ProposedExercises2.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditure;
        }

        public override double Tax()
        {
            double percentualIncome, offHealth = 0.0;
            if (HealthExpenditures > 0)
            {
                offHealth = HealthExpenditures * 0.5;
            }

            if (AnualIncome < 20000.0)
            {
                percentualIncome = 0.15;
            }
            else
            {
                percentualIncome = 0.25;
            }
            return AnualIncome * percentualIncome - offHealth;
        }

    }
}
