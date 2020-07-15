using System;
using Xunit;
using OrderProcesssingLibrary;
using System.Net.Http.Headers;

namespace OrderProcesssingTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Product p = new Product()
            {
                ProductType = (int)ProductTypes.ProdType.Physical,
                ProductName = "Physical"

            };
            IPacking packing = new PackingSlip();
            var order = new Order(packing);

            Assert.False(order.ProcessOrder());
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
