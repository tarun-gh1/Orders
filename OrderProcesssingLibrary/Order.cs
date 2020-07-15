using System;

namespace OrderProcesssingLibrary
{
    public class Order
    {
        private readonly IProduct product;

        public Order(IProduct product)
        {
            this.product = product;
        }
    }
}
