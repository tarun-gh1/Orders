using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssingLibrary
{
    public class Notify : INotify
    {
        public void NotifyUser(string purpose)
        {
            Console.WriteLine($"User notified. Purpose: {purpose}");
        }
    }
}
