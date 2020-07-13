using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy.ArrayBackedCompositeProxy
{
    public class MasonrySettings
    {
        public bool? All
        {
            set
            {
                if (!value.HasValue) return;
                for (var i = 0; i < _flags.Length; i++)
                {
                    _flags[i] = value.Value;
                }
            }
            get
            {
                if (_flags.Skip(1).All(x => x == _flags[0]))
                {
                    return _flags[0];
                }
                else
                {
                    return null;
                }

            }
        }
        private readonly bool[] _flags = new bool[3];

        public bool Pillars
        {
            get => _flags[0];
            set => _flags[0] = value;
        }

        public bool Walls
        {
            get => _flags[1];
            set => _flags[1] = value;
        }

        public bool Floors
        {
            get => _flags[2];
            set => _flags[2] = value;
        }
    }
}
