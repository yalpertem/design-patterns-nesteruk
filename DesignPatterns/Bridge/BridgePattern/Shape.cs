using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.BridgePattern
{
    public abstract class Shape
    {
        protected IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract string Draw();

        public abstract float Resize(float factor);
    }
}
