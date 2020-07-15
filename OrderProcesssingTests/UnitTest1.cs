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
            Product product = new Product()
            {
                ProductType = (int)ProductTypes.ProdType.Physical,
                ProductName = "Physical"

            };
            IPacking packing = new PackingSlip();
            INotify notify = new NotifyUser();
            var order = new Order(packing, notify);

            Assert.False(order.ProcessOrder(product));
        }

        class PackingSlip : IPacking
        {
            public void GenerateSlip()
            {
                throw new NotImplementedException();
            }
        }
    }
}
