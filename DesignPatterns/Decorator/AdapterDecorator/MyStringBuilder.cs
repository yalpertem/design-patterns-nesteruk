using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DesignPatterns.Decorator.AdapterDecorator
{
    public class MyStringBuilder
    {
        private StringBuilder _builder = new StringBuilder();

        public static implicit operator MyStringBuilder(string s)
        {
            var msb = new MyStringBuilder();
            msb._builder.Append(s);
            return msb;
        }

        public static MyStringBuilder operator +(MyStringBuilder msb, string s)
        {
            msb.Append(s);
            return msb;
        }

        public override string ToString()
        {
            return _builder.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)_builder).GetObjectData(info, context);
        }

        public int EnsureCapacity(int capacity)
        {
            return _builder.EnsureCapacity(capacity);
        }

        public string ToString(int startIndex, int length)
        {
            return _builder.ToString(startIndex, length);
        }

        public MyStringBuilder Clear()
        {
            _builder.Clear();
            return this;
        }

        public MyStringBuilder Append(char value, int repeatCount)
        {
            _builder.Append(value, repeatCount);
            return this;
        }

        public MyStringBuilder Append(char[] value, int startIndex, int charCount)
        {
            _builder.Append(value, startIndex, charCount);
            return this;
        }

        public MyStringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(string value, int startIndex, int count)
        {
            _builder.Append(value, startIndex, count);
            return this;
        }

        public MyStringBuilder AppendLine()
        {
            _builder.AppendLine();
            return this;
        }

        public MyStringBuilder AppendLine(string value)
        {
            _builder.AppendLine(value);
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            _builder.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public MyStringBuilder Insert(int index, string value, int count)
        {
            _builder.Insert(index, value, count);
            return this;
        }

        public MyStringBuilder Remove(int startIndex, int length)
        {
            _builder.Remove(startIndex, length);
            return this;
        }

        public MyStringBuilder Append(bool value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(sbyte value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(byte value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(char value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(short value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(int value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(long value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(float value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(double value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(decimal value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(ushort value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(uint value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(ulong value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(object value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Append(char[] value)
        {
            _builder.Append(value);
            return this;
        }

        public MyStringBuilder Insert(int index, string value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, bool value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, sbyte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, byte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, short value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, char value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, char[] value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
        {
            _builder.Insert(index, value, startIndex, charCount);
            return this;
        }

        public MyStringBuilder Insert(int index, int value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, long value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, float value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, double value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, decimal value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, ushort value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, uint value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, ulong value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder Insert(int index, object value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public MyStringBuilder AppendFormat(string format, object arg0)
        {
            _builder.AppendFormat(format, arg0);
            return this;
        }

        public MyStringBuilder AppendFormat(string format, object arg0, object arg1)
        {
            _builder.AppendFormat(format, arg0, arg1);
            return this;
        }

        public MyStringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
        {
            _builder.AppendFormat(format, arg0, arg1, arg2);
            return this;
        }

        public MyStringBuilder AppendFormat(string format, params object[] args)
        {
            _builder.AppendFormat(format, args);
            return this;
        }

        public MyStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
        {
            _builder.AppendFormat(provider, format, args);
            return this;
        }

        public MyStringBuilder Replace(string oldValue, string newValue)
        {
            _builder.Replace(oldValue, newValue);
            return this;
        }

        public bool Equals(MyStringBuilder sb)
        {
            return _builder.Equals(sb);
        }

        public MyStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            _builder.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public MyStringBuilder Replace(char oldChar, char newChar)
        {
            _builder.Replace(oldChar, newChar);
            return this;
        }

        public MyStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            _builder.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public int Capacity
        {
            get => _builder.Capacity;
            set => _builder.Capacity = value;
        }

        public int MaxCapacity => _builder.MaxCapacity;

        public int Length
        {
            get => _builder.Length;
            set => _builder.Length = value;
        }

        public char this[int index]
        {
            get => _builder[index];
            set => _builder[index] = value;
        }
    }
}
