using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.ProtectionProxy
{
    public class Car : ICar
    {
        public string Drive()
        {
            return "driving";
        }
    }
}
