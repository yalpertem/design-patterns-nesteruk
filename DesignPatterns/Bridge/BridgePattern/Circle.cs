using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.BridgePattern
{
    public class Circle : Shape
    {
        private float _radius;

        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            _radius = radius;
        }

        public override string Draw()
        {
            var render = _renderer.RenderCircle(_radius);
            return render;
        }

        public override float Resize(float factor)
        {
            _radius *= factor;
            return _radius;
        }
    }
}
