using System;
using Xunit;
using OrderProcesssingLibrary;
using System.Net.Http.Headers;
using System.Collections.Specialized;

namespace OrderProcesssingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IProduct product = new Product()
            {
                ProductType = (int)ProductTypes.ProdType.Physical,
                ProductName = "Physical",
                Purpose = "Upgrade"

            };
            IPacking packing = new PackingSlip();
            INotify notify = new Notify();
            IMembership membership = new Membership();
            var order = new Order(packing, notify, membership);

            Assert.False(order.ProcessOrder(product));
        }

        class Order1
        {
            public Order1(IPacking packing, INotify notify, IMembership membership)
            {

            }
            public bool ProcessOrder(IProduct product)
            {
                return false;
            }
        }
        class PackingSlip : IPacking
        {
            public void GenerateDuplicateSlip(int Dept)
            {
                
            }

            public void GenerateSlip()
            {
               
            }

            public void AddFreeVideo()
            {

            }
        }
    }
}
