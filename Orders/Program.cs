using OrderProcesssingLibrary;
using System;
using System.Data;
using System.Net.Http.Headers;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = new Product()
            {
                ProductType = (int)ProductTypes.ProdType.Video,
                ProductName = "Learning to Ski",
                Purpose = "Upgrade"

            };
            IPacking packing = new PackingSlip();
            INotify notify = new Notify();
            IMembership membership = new Membership();
            var order = new Order(packing, notify, membership);
            order.ProcessOrder(product);

            Console.ReadLine();
        }
    }
}
