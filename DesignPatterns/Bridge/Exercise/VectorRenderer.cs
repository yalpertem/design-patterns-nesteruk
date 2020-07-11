using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Exercise
{
    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "lines";
    }
}
