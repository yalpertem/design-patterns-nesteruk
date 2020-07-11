using System;

namespace DesignPatterns.Adapter.GenericValueAdapter
{
    /// <summary>
    /// Vector2f, Vector3i
    /// </summary>
    public class Vector<TSelf, T, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, T, D>, new()
    {
        protected T[] data;

        public Vector()
        {
            data = new T[new D().Value];
        }

        public Vector(params T[] values)
        {
            var requiredSize = new D().Value;
            data = new T[requiredSize];
            var providedSize = values.Length;

            for (var i = 0; i < Math.Min(requiredSize, providedSize); i++)
            {
                data[i] = values[i];
            }
        }

        public static TSelf Create(params T[] values)
        {
            var result = new TSelf();
            var requiredSize = new D().Value;
            result.data = new T[requiredSize];
            var providedSize = values.Length;

            for (var i = 0; i < Math.Min(requiredSize, providedSize); i++)
            {
                result.data[i] = values[i];
            }
            return result;
        }

        public T this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }
    }
}