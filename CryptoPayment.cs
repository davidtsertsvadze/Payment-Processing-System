using Final_Payment_Processing_System;
using static Final_Payment_Processing_System.Program;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Payment_Proccessing_System
{
    internal class CryptoPayment : IPaymentProcessor
    {
        private static readonly Random _random = new Random();

        public PaymentResult Process(decimal amount)
        {
            bool isSuccess = _random.Next(0, 2) == 1;

            if (isSuccess)
            {
                return new PaymentResult(
                    amount,
                    PaymentStatus.Success,
                    "Crypto payment confirmed",
                    DateTime.Now
                );
            }

            return new PaymentResult(
                amount,
                PaymentStatus.Failed,
                "Blockchain validation failed",
                DateTime.Now
            );
        }
    }
}
