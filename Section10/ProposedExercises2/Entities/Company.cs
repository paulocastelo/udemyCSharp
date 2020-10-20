namespace ProposedExercises2.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployess { get; set; }
        public Company() { }
        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployess = numberOfEmployees;
        }
        public override double Tax()
        {
            double percentualIncome = 0.0;

            if (NumberOfEmployess > 10)
            {
                percentualIncome = 0.14;
            }
            else
            {
                percentualIncome = 0.16;
            }
            return AnualIncome * percentualIncome;
        }
    }
}
