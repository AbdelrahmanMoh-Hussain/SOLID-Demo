using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.SingleResponsibility
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        public Order(int id, string customerName, string itemName, decimal price)
        {
            Id = id;
            CustomerName = customerName;
            ItemName = itemName;
            Price = price;
        }

        public void ProcessOrder()
        {
            // Process the order logic here
            Console.WriteLine($"Processing order {Id} for customer {CustomerName}");
        }
    }
}
