using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.ExplicitDeepCopyInterface
{
    public class Address : IPrototype<Address>
    {
        public string StreetName { get; set; }

        public string Postcode { get; set; }

        public Address(string streetName, string postcode)
        {
            Postcode = postcode;
            StreetName = streetName;
        }

        public Address DeepCopy()
        {
            return new Address(StreetName, Postcode);
        }
    }
}
