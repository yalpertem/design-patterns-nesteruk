namespace DesignPatterns.Builder.FluentBuilderPattern
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