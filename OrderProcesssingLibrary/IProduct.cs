using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public interface IProduct
    {
        int ProductType { get; set; }
        string ProductName { get; set; }
    }
}
