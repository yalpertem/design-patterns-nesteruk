using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.FacetedBuilderPattern
{
    public class PersonBuilder //facade
    {
        /// <summary>
        /// It's used as a reference
        /// </summary>
        protected Person _person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(_person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(_person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb._person;
        }
    }
}
