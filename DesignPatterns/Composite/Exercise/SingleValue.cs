using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Exercise
{

    public class SingleValue : IValueContainer
    {
        public int Value;

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
