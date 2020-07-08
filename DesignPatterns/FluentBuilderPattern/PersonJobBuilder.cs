using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilderPattern
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
        where SELF : PersonJobBuilder<SELF>
    {
        public PersonJobBuilder<SELF> WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
