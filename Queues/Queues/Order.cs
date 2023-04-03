using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Order
    {
        //Order ID
        public int OrderId { get; set; }
        //Quantity of the order
        public int OrderQuantity { get; set; }

        //Simple Constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //Print message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }

    }
}
