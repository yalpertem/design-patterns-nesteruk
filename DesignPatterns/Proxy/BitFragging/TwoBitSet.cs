using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.BitFragging
{
    /// <summary>
    /// 64 bits ==> 32 values
    /// </summary>
    public class TwoBitSet
    {
        private readonly ulong _data;

        public TwoBitSet(ulong data)
        {
            _data = data;
        }

        public byte this[int index]
        {
            get
            {
                // 00 10 01 01
                var shift = index << 1;
                ulong mask = (0b11U << shift); // 00 11 00 00
                return (byte)((_data & mask) >> shift);
            }
        }
    }
}
