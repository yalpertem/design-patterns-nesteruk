using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.GenericValueAdapter
{
    public class VectorOfFloat<TSelf, D> : Vector<TSelf, float, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, float, D>, new()
    {
        public VectorOfFloat() { }

        public VectorOfFloat(params float[] values) : base(values) { }

        public static VectorOfFloat<TSelf, D> operator +(VectorOfFloat<TSelf, D> lhs, VectorOfFloat<TSelf, D> rhs)
        {
            var result = new VectorOfFloat<TSelf, D>();
            var dim = new D().Value;
            for (var i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }
            return result;
        }
    }
}
