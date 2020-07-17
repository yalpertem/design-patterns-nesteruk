using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.WithEvent
{
    public class FallsIllEventArgs : EventArgs
    {
        public string Address { get; set; }
    }
}
