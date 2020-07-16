using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class Mediator
    {
        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }

        public event EventHandler<int> Alert;
    }
}
