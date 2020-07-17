using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ViaInterfaces
{
    public class PersonObserver : IObserver<Event>
    {
        public PersonObserver()
        {
            var person = new Person();
            var sub = person.Subscribe(this);
            person.FallIll();
        }

        public void OnCompleted() { }

        public void OnError(Exception error) { }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
            {
                Console.Write($"Doctor goes to {args.Adress}");
            }
        }
    }
}
