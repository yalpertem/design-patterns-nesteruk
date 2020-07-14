using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter.LexingAndParsing
{
    public class Integer : IElement
    {
        public Integer(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
