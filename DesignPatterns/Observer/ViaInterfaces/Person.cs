using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer.ViaInterfaces
{
    public class Person : IObservable<Event>
    {
        private readonly HashSet<Subscription> _subscriptions
            = new HashSet<Subscription>();

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            _subscriptions.Add(subscription);
            return subscription;
        }

        public void FallIll()
        {
            foreach (var s in _subscriptions)
            {
                s.Observer.OnNext(new FallsIllEvent
                {
                    Adress = "123 London"
                });
            }
        }

        private class Subscription : IDisposable
        {
            private readonly Person _person;
            public readonly IObserver<Event> Observer;

            public Subscription(Person person, IObserver<Event> observer)
            {
                _person = person;
                Observer = observer;
            }
            public void Dispose()
            {
                _person._subscriptions.Remove(this);
            }
        }
    }
}
