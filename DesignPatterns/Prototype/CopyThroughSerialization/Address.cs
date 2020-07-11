using System;

namespace DesignPatterns.Prototype.CopyThroughSerialization
{
    [Serializable]
    public class Address
    {
        public string StreetName { get; set; }

        public string Postcode { get; set; }

        public Address()
        {
        }

        public Address(string streetName, string postcode)
        {
            Postcode = postcode;
            StreetName = streetName;
        }
    }
}