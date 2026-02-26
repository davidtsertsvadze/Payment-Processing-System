using Final_Payment_Processing_System;
using System;
using System.Collections.Generic;
using System.Text;
using static Final_Payment_Processing_System.Program;

namespace Final_Payment_Proccessing_System
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            this._processor = processor;
        }

        public PaymentResult Pay(decimal amount)
        {
            return _processor.Process(amount);
        }
    }
}
