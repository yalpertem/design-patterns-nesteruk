using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.CopyThroughSerialization
{
    [Serializable]
    public class Address
    {
        public string StreetName { get; set; }

        public string Postcode { get; set; }

        public Address() { }

        public Address(string streetName, string postcode)
        {
            Postcode = postcode;
            StreetName = streetName;
        }
    }
}
