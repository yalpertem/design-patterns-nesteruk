using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Proxy.ValueProxy
{
    public struct Percentage
    {
        private readonly float _value;

        internal Percentage(float value)
        {
            _value = value;
        }

        public static float operator *(float f, Percentage p)
        {
            return f * p._value;
        }

        public static Percentage operator +(Percentage p1, Percentage p2)
        {
            return new Percentage(p1._value + p2._value);
        }

        public override string ToString()
        {
            var formatted = Math.Round(_value * 100, 0);
            return $"{formatted}%";
        }
    }
}
