using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight.TextFormatting
{
    public class BetterFormattedText
    {
        private readonly string _plainText;
        private readonly List<TextRange> _formatting = new List<TextRange>();

        public BetterFormattedText(string plainText)
        {
            _plainText = plainText;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < _plainText.Length; i++)
            {
                var c = _plainText[i];
                foreach (var range in _formatting)
                {
                    if (range.Covers(i) & range.Capitalize)
                    {
                        c = char.ToUpper(c);
                    }
                }
                sb.Append(c);
            }
            return sb.ToString();
        }

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange() { Start = start, End = end };
            _formatting.Add(range);
            return range;
        }
    }

    public class TextRange
    {
        public int Start { get; set; }
        public int End { get; set; }

        public bool Capitalize { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}
