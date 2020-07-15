using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public class PackingSlip : IPacking
    {
        public void AddFreeVideo()
        {
            Console.WriteLine("Free video added");
        }

        public void GenerateDuplicateSlip(int Dept)
        {
            string deptName = Enum.GetName(typeof(Department), Dept);
            Console.WriteLine($"Dulicate packing slip generated. Department: {deptName}");
        }

        public void GenerateSlip()
        {
            Console.WriteLine("Packing slip generated");
        }        
    }
}
