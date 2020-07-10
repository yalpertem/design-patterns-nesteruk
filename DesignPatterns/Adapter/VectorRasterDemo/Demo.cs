using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.VectorRasterDemo
{
    public static class Demo
    {
        private static readonly List<VectorObject> vectorObjects =
            new List<VectorObject>()
            {
                new VectorRectangle(1,1,10,10),
                new VectorRectangle(3,3,6,6)
            };

        /// <summary>
        /// The method which we are trying to adapt.
        /// </summary>
        /// <param name="p"></param>
        public static void DrawPoint(Point p)
        {
            Console.WriteLine(".");
        }
    }
}
