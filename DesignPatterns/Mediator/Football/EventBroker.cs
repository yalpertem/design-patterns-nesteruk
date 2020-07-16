using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesignPatterns.Mediator.Football
{
    public class EventBroker : IObservable<PlayerEvent>
    {
        private readonly Subject<PlayerEvent> _subscriptions = new Subject<PlayerEvent>();

        public IDisposable Subscribe(IObserver<PlayerEvent> observer)
        {
            return _subscriptions.Subscribe(observer);
        }

        public void Publish(PlayerEvent pe)
        {
            _subscriptions.OnNext(pe);
        }
    }
}
