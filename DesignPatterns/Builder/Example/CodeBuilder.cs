using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Example
{
    public class CodeBuilder
    {
        private string _className { get; set; }
        private List<CodeBuilderProperty> _properties { get; set; }
        private const int IndentLength = 2;

        public CodeBuilder(string className)
        {
            _className = className;
            _properties = new List<CodeBuilderProperty>();
        }

        public CodeBuilder AddField(string name, string type)
        {
            _properties.Add(new CodeBuilderProperty(name, type));
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {_className}");
            sb.AppendLine("{");
            foreach (var property in _properties)
            {
                sb.Append(new string(' ', IndentLength));
                sb.AppendLine($"public {property.Type} {property.Name};");
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
