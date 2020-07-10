using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.AmbientContext
{
    public class Building
    {
        public List<Wall> Walls { get; set; }

        public Building()
        {
            Walls = new List<Wall>();
        }
    }
}
