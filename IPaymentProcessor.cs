using System;
using System.Collections.Generic;
using System.Text;
using static Final_Payment_Processing_System.Program;

namespace Final_Payment_Processing_System
{
    internal interface IPaymentProcessor
    {
        PaymentResult Process(decimal amount);
    }
}
