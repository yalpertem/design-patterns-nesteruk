using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.BuilderPattern
{
    public class HtmlElement
    {
        private const int _indentLength = 2;
        public string Tag { get; set; }
        public string Text { get; set; }
        public IList<HtmlElement> Elements { get; set; }

        public HtmlElement(string tag, string text)
        {
            Tag = tag;
            Text = text;
        }

        public string ToStringImpl(int indent)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetBlanks(indent));
            sb.AppendLine($"<{Tag}>");
            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(GetBlanks(indent + 1));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

            sb.Append(GetBlanks(indent));
            sb.AppendLine($"</{Tag}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        private string GetBlanks(int indent)
        {
            return new string(' ', indent * _indentLength);
        }
    }
}