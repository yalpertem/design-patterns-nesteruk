using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Prototype.CopyThroughSerialization
{
    [Serializable]
    public class Person 
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person() { }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }
    }
}
