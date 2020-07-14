using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter.LexingAndParsing
{
    public class Token
    {
        public enum Type
        {
            Integer, Plus, Minus, Lparen, Rparen
        }

        public Type MyType { get; set; }

        public string Text { get; set; }

        public Token(Type myType, string text)
        {
            MyType = myType;
            Text = text;
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
