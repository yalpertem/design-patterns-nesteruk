using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factories.Exercise
{
    public class PersonFactory
    {
        private List<Person> _persons = new List<Person>();
        public Person CreatePerson(string name)
        {
            var person = new Person()
            {
                Name = name,
                Id = _persons.Count
            };
            _persons.Add(person);
            return person;
        }
    }
}
