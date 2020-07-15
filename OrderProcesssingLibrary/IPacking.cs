using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public interface IPacking
    {
        void GenerateSlip();
        void GenerateDuplicateSlip(int Dept);
        void AddFreeVideo();
    }
}
