using S14FixationExercises.Entities;
using System;

namespace S14FixationExercises.Services
{
    class ContractService
    {
        private IOnlinePaymentService _payService;
        public ContractService(IOnlinePaymentService payService)
        {
            _payService = payService;
        }
        public void processContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _payService.interest(basicQuota, i);
                double fullQuota = updatedQuota + _payService.paymentFee(updatedQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}
