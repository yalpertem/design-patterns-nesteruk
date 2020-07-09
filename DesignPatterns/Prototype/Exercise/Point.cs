using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype.Exercise
{
    public class Point
    {
        public int X, Y;

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }
    }
}




