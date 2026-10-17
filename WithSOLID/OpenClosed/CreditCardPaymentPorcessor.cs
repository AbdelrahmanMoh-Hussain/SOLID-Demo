using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.OpenClosed
{
    internal class CreditCardPaymentPorcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Process credit card payment logic here
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    
    }
}
