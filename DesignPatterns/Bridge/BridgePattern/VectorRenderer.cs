using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.BridgePattern
{
    public class VectorRenderer : IRenderer
    {
        public string RenderCircle(float radius)
        {
            Console.WriteLine($"Vector rendering for radius:{radius}");
            return "vector";
        }
    }
}
