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

        public bool ProcessOrder(IProduct product)
        {
            bool orderProcessed = false;
            switch(product.ProductType)
            {
                case (int)ProductTypes.ProdType.Physical:

                    break;
                default:
                    break;
            }
            return orderProcessed;
        }
    }
}
