using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Exercise
{
    public abstract class Shape
    {
        private IRenderer _renderer;
        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {_renderer.WhatToRenderAs}";
        }
    }
}
