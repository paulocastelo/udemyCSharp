using System;
using System.Collections.Generic;
using System.Text;

namespace S14FixationExercises.Services
{
    class PayPalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double paymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
