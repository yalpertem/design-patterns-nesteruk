using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.ProtectionProxy
{
    public class Driver
    {
        public int Age { get; set; }

        public Driver(int age)
        {
            Age = age;
        }
    }
}
