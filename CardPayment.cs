using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using static Final_Payment_Processing_System.Program;

namespace Final_Payment_Processing_System
{
    internal class CardPayment : IPaymentProcessor
    {
        public PaymentResult Process(decimal amount)
        {
            if (amount > 1000)
            {
                return new PaymentResult(
                    amount,
                    PaymentStatus.Failed,
                    "Limite exceeded",
                    DateTime.Now
                    );
            }
            else
            {
                return new PaymentResult(
                    amount,
                    PaymentStatus.Success,
                    "Payment Successful",
                    DateTime.Now
                    );
        }   }
    }
}
