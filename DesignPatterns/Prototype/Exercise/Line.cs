namespace DesignPatterns.Prototype.Exercise
{
    public class Line
    {
        public Point Start, End;

        public Line()
        {
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(
                new Point(Start),
                new Point(End));
        }
    }
}