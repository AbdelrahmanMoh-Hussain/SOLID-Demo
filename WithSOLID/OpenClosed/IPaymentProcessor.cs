using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.OpenClosed
{
    internal interface IPaymentProcessor
    {
        internal void ProcessPayment(decimal amount);
    }
}
