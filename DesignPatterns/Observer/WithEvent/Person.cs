using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.WithEvent
{
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs()
            {
                Address = "123 London Road"
            });
        }

        public event EventHandler<FallsIllEventArgs> FallsIll;
    }
}
