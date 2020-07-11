using System.Linq;

namespace DesignPatterns.Prototype.ExplicitDeepCopyInterface
{
    public class Person : IPrototype<Person>
    {
        public string[] Names { get; set; }

        public Address Address { get; set; }

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(Names.ToArray(), Address.DeepCopy());
        }
    }
}