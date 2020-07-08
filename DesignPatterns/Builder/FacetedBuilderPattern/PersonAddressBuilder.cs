using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.FacetedBuilderPattern
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            _person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            _person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            _person.PostCode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            _person.City = city;
            return this;
        }
    }
}
