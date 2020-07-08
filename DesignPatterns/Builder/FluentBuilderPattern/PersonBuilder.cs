using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.FluentBuilderPattern
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }

    }
}
