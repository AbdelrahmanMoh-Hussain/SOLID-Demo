using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.SingleResponsibility
{
    public class EcomStore
    {
        public void ProcessOrder(Order order)
        {
            // Add to cart
            Console.WriteLine($"Adding item {order.ItemName} to cart for customer {order.CustomerName}");
            // Additional cart logic here

            // Process the order
            Console.WriteLine($"Processing order {order.Id} for customer {order.CustomerName}");
            // Additional order processing logic here

            // Generate invoice for the order
            Console.WriteLine($"Generating invoice for order {order.Id}");
            // Additional invoice generation logic here
        }
    }
}
