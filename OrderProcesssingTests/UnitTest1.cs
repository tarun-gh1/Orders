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
            var order = new Order(Product p);
        }
    }
}
