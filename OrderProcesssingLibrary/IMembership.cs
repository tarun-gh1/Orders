using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public interface IMembership
    {
        public string Purpose { get; set; }
        void Upgrade();
        void Activate();

    }
}
