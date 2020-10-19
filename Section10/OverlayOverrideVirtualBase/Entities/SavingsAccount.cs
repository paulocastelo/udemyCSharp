using OverlayOverrideVirtualBase.Entities;
namespace OverlayOverrideVirtualBase.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            //Balance -= amount;        //Overriding method with no discount
            base.WithDraw(amount);      //Using part of existing method
            Balance -= 2.0;             //Inserting new procedures to virtual method
        }
    }
}
