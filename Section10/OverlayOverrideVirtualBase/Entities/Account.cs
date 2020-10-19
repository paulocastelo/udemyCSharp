using System;
namespace OverlayOverrideVirtualBase.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public Double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
