namespace DesignPatterns.Builder.BuilderPattern
{
    public class HtmlBuilder
    {
        private string _name { get; set; }

        public HtmlElement Root { get; set; }

        public HtmlBuilder(string name)
        {
            _name = name;
            Root = new HtmlElement(_name, null);
        }

        public HtmlBuilder AddChild(string tag, string text)
        {
            var child = new HtmlElement(tag, text);
            Root.Elements.Add(child);
            return this; //fluent builder
        }

        public override string ToString()
        {
            return Root.ToString();
        }

        public void Clear()
        {
            Root = new HtmlElement(_name, null);
        }
    }
}