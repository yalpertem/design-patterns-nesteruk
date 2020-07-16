using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Iterator.ArrayBackedProperties
{
    public class Creature : IEnumerable<int>
    {
        private readonly int[] _stats = new int[3];
        private const int _strength = 0;
        private const int _agility = 1;
        private const int _intelligence = 2;
        public int Strength
        {
            get => _stats[_strength];
            set => _stats[_strength] = value;
        }

        public int Agility
        {
            get => _stats[_agility];
            set => _stats[_agility] = value;
        }

        public int Intelligence
        {
            get => _stats[_intelligence];
            set => _stats[_intelligence] = value;
        }

        public int this[int index]
        {
            get => _stats[index];
            set => _stats[index] = value ;
        }

        public double AveregeStat => _stats.Average();

        public IEnumerator<int> GetEnumerator()
        {
            return _stats.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
