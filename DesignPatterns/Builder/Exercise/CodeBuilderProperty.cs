namespace DesignPatterns.Builder.Exercise
{
    internal class CodeBuilderProperty
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public CodeBuilderProperty(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}