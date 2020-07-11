using System.Linq;

namespace DesignPatterns.Prototype.CopyConstructors
{
    public class Person
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person(Person other)
        {
            Names = other.Names.ToArray();
            Address = new Address(other.Address);
        }
    }
}