using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter.VectorRasterDemo
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line()
        {
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public override bool Equals(object obj)
        {
            return obj is Line line &&
                   EqualityComparer<Point>.Default.Equals(Start, line.Start) &&
                   EqualityComparer<Point>.Default.Equals(End, line.End);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }
    }
}