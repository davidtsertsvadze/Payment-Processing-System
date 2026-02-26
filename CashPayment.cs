using Final_Payment_Processing_System;
using System;
using System.Collections.Generic;
using System.Text;
using static Final_Payment_Processing_System.Program;

namespace Final_Payment_Proccessing_System
{
    internal class CashPayment : IPaymentProcessor
    {
        public PaymentResult Process(decimal amount)
        {
            return new PaymentResult(
                amount,
                PaymentStatus.Success,
                "Payment Successful",
                DateTime.Now
                );
        }
    }
}
