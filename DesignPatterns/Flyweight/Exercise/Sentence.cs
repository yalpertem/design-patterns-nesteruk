using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight.Exercise
{
    public class Sentence
    {
        private readonly string[] _words;
        private Dictionary<int, WordToken> _tokens;

        public Sentence(string plainText)
        {
            _words = plainText.Split(' ');
            _tokens = new Dictionary<int, WordToken>();
        }

        public WordToken this[int index]
        {
            get
            {
                if (!_tokens.ContainsKey(index))
                {
                    var token = new WordToken();
                    _tokens[index] = token;
                }
                return _tokens[index];
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < _words.Length; i++)
            {
                var str = _words[i];
                if (_tokens.ContainsKey(i) && _tokens[i].Capitalize)
                {
                    str = str.ToUpper();
                }
                sb.Append(str);
                if (i + 1 < _words.Length)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
