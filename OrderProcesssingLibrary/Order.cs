using System;

namespace OrderProcesssingLibrary
{
    public class Order
    {
       private readonly IPacking packing;

        public Order(IPacking packing)
        {
            this.packing = packing;
        }

        public bool ProcessOrder()
        {
            bool orderProcessed = false;

            return orderProcessed;
        }
    }
}
