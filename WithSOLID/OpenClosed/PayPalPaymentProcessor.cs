using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.OpenClosed
{
    internal class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            // Process PayPal payment logic here
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    {
    }
}
