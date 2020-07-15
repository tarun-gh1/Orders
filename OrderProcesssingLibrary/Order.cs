using System;

namespace OrderProcesssingLibrary
{
    public class Order
    {
       private readonly IPacking packing;
        private readonly INotify notify;
        private readonly IMembership membership;

        public Order(IPacking packing, INotify notify, IMembership membership)
        {
            this.packing = packing;
            this.notify = notify;
            this.membership = membership;
        }

        public bool ProcessOrder(IProduct product)
        {
            bool orderProcessed = false;
            switch(product.ProductType)
            {
                case (int)ProductTypes.ProdType.Physical:
                    packing.GenerateSlip();
                    orderProcessed = true;
                    break;
                case (int)ProductTypes.ProdType.Book:
                    packing.GenerateDuplicateSlip((int)Department.Royalty);
                    orderProcessed = true;
                    break;
                case (int)ProductTypes.ProdType.Membership:
                    if (product.Purpose == "Activate")
                    {
                        membership.Activate();
                        notify.NotifyUser(product.Purpose);
                    }
                    else if (product.Purpose == "Upgrade")
                    {
                        membership.Upgrade();
                        notify.NotifyUser(product.Purpose);
                    }
                    orderProcessed = true;
                    break;
                case (int)ProductTypes.ProdType.Video:
                    if(String.Equals(product.ProductName, "Learning to Ski"))
                    {
                        packing.GenerateSlip();
                        packing.AddFreeVideo();
                    }
                    orderProcessed = true;
                    break;
                default:
                    break;
            }
            return orderProcessed;
        }
    }
}
