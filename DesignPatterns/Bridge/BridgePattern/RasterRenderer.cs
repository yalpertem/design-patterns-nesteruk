using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.BridgePattern
{
    public class RasterRenderer : IRenderer
    {
        public string RenderCircle(float radius)
        {
            Console.WriteLine($"Raster rendering for radius:{radius}");
            return "raster";
        }
    }
}
