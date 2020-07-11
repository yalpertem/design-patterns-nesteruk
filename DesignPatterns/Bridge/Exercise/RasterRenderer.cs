using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Exercise
{
    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }
}
