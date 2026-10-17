using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.OpenClosed
{
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentMethod, decimal amount)
        {
            if (paymentMethod == "CreditCard")
            {
                // Process credit card payment
                Console.WriteLine($"Processing credit card payment of {amount:C}");
            }
            else if (paymentMethod == "PayPal")
            {
                // Process PayPal payment
                Console.WriteLine($"Processing PayPal payment of {amount:C}");
            }
            else if (paymentMethod == "BankTransfer")
            {
                // Process bank transfer payment
                Console.WriteLine($"Processing bank transfer payment of {amount:C}");
            }
            // Add more payment methods here as needed
            else
            {
                throw new NotSupportedException($"Payment method '{paymentMethod}' is not supported.");
            }
        }
    }
}
