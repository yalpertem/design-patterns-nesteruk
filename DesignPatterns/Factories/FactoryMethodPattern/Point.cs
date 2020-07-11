using System;

namespace DesignPatterns.Factories.FactoryMethodPattern
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(
                rho * Math.Cos(theta),
                rho * Math.Sin(theta));
        }

        private Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}