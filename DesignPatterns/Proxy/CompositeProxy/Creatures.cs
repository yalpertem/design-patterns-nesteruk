using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesignPatterns.Proxy.CompositeProxy
{
    /// <summary>
    /// SoA: Array of structures
    /// </summary>
    public class Creatures
    {
        private readonly int _size;
        private readonly byte[] _age;
        private readonly int[] _x, _y;

        public Creatures(int size)
        {
            _size = size;
            _age = new byte[size];
            _x = new int[size];
            _y = new int[size];
        }

        /// <summary>
        /// CreatureProxy is used for perfomance improvements.
        /// Holding Age, X, Y in separate arrays makes it faster
        /// to be updated for a list of Creatures.
        /// </summary>
        public struct CreatureProxy
        {
            private readonly Creatures _creatures;
            private readonly int _index;

            public CreatureProxy(Creatures creatures, int index)
            {
                _creatures = creatures;
                _index = index;
            }

            public ref byte Age => ref _creatures._age[_index];
            public ref int X => ref _creatures._x[_index];
            public ref int Y => ref _creatures._y[_index];
        }

        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (var pos = 0; pos < _size; pos++)
            {
                yield return new CreatureProxy(this, pos);
            }
        }
    }
}
