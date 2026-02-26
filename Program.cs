using Final_Payment_Proccessing_System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Payment_Processing_System
{
    class Program
    {
        // create enum for payment status
        public enum PaymentStatus
        {
            Pending,
            Success,
            Failed
        }

        //create record for payment result
        public record PaymentResult(decimal Amount, PaymentStatus Status, string Messege, DateTime  ProcessedAt);

            static void Main(string[] args)
            {
                IPaymentProcessor cardPayment = new CardPayment();
                IPaymentProcessor cashPayment = new CashPayment();
                IPaymentProcessor cryptoPayment = new CryptoPayment();

                PaymentService service = new PaymentService(cryptoPayment);
                PaymentResult result = service.Pay(900);

                Console.WriteLine("Status: " + result.Status);
                Console.WriteLine("Messege: " + result.Messege);
                Console.WriteLine("Payment time: " + result.ProcessedAt);
                Console.WriteLine(result);
        }
    }
}