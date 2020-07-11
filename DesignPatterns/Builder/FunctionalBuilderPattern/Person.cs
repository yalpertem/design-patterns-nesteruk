namespace DesignPatterns.Builder.FunctionalBuilderPattern
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public Person()
        {
        }

        public Person(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}