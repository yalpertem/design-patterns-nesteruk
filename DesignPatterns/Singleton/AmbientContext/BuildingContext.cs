using System;
using System.Collections.Generic;

namespace DesignPatterns.Singleton.AmbientContext
{
    public sealed class BuildingContext : IDisposable
    {
        public int WallHeight { get; set; }

        private static Stack<BuildingContext> stack =
            new Stack<BuildingContext>();

        public BuildingContext(int wallHeight)
        {
            WallHeight = wallHeight;
            stack.Push(this);
        }

        static BuildingContext()
        {
            stack.Push(new BuildingContext(0));
        }

        public static BuildingContext Current => stack.Peek();

        public void Dispose()
        {
            if (stack.Count > 1)
            {
                stack.Pop();
            }
        }
    }
}