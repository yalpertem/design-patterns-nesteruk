using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight.RepeatingUserNames
{
    public class User2
    {
        static List<string> _strings = new List<string>();
        private int[] _names;

        public User2(string fullName)
        {
            _names = fullName.Split(' ').Select(GetOrAdd).ToArray();
        }

        private int GetOrAdd(string s)
        {
            int idx = _strings.IndexOf(s);
            if (idx != -1) return idx;
            else
            {
                _strings.Add(s);
                return _strings.Count - 1;
            }
        }

        public string FullName => string.Join(" ", _names.Select(x => _strings[x]));
    }
}
