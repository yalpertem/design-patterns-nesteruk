using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.CopyConstructors
{
    public class Address
    {
        public string StreetName { get; set; }

        public string Postcode { get; set; }

        public Address(string streetName, string postcode)
        {
            Postcode = postcode;
            StreetName = streetName;
        }

        public Address(Address other)
        {
            Postcode = other.Postcode;
            StreetName = other.StreetName;
        }
    }
}
