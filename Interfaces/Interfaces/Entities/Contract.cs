using Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;


namespace Interfaces.Entities
{
    class Contract
    {
        public int ContractNumber { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public IOnlinePaymentServices PaymentServices { get; set; }

        List<Installment> Installments = new List<Installment>();
        

        public Contract()
        {

        }

        public Contract(int contractNumber, DateTime date, double totalValue, IOnlinePaymentServices paymentServices)
        {
            ContractNumber = contractNumber;
            Date = date;
            TotalValue = totalValue;
            PaymentServices = paymentServices;
        }
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }
    }
}
