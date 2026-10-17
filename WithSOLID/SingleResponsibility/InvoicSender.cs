using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.SingleResponsibility
{
    public interface InvoicSender
    {
        void SendInvoice(Order order);
    }
}
