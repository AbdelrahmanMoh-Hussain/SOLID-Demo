using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.SingleResponsibility
{
    public class Cart
    {
        public void AddToCart(Order order)
        {
            // Add to cart logic here
            Console.WriteLine($"Adding item {order.ItemName} to cart for customer {order.CustomerName}");
        }
    }
}
