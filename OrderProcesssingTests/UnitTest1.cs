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
            var order = new Order(p);
        }
    }
}
