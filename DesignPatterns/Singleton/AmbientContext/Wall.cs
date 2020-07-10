using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.AmbientContext
{
    public class Wall
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public int Height { get; set; }
        public Wall()
        {

        }

        public Wall(Point start, Point end)
        {
            Start = start;
            End = end;
            Height = BuildingContext.Current.WallHeight;
        }
    }
}
