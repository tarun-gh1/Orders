using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public class Product : IProduct
    {
        public int ProductType { get; set; }
        public string ProductName { get; set; }
        public string Purpose { get ; set ; }
    }
}
