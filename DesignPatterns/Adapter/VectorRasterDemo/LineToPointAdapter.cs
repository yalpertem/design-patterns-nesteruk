using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Adapter.VectorRasterDemo
{
    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int count;

        private static Dictionary<int, List<Point>> _cache =
            new Dictionary<int, List<Point>>();

        public LineToPointAdapter(Line line)
        {
            var hashCode = line.GetHashCode();
            if (_cache.ContainsKey(hashCode))
            {
                return;
            }

            var points = new List<Point>();

            Console.WriteLine($"{++count}: Generating points for line " +
                $"[{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}]");

            var left = Math.Min(line.Start.X, line.End.X);
            var right = Math.Max(line.Start.X, line.End.X);
            var top = Math.Max(line.Start.Y, line.End.Y);
            var bottom = Math.Min(line.Start.Y, line.End.Y);
            var dx = right - left;
            var dy = top - bottom;

            if (dx == 0)
            {
                for (int y = bottom; y <= top; ++y)
                {
                    points.Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x <= top; ++x)
                {
                    points.Add(new Point(x, top));
                }
            }

            _cache.Add(line.GetHashCode(), points);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return _cache.Values.SelectMany(x => x).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}