using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Exercise
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square _square;
        public SquareToRectangleAdapter(Square square)
        {
            _square = square;
        }

        public int Width => _square.Side;

        public int Height => _square.Side;
    }
}
