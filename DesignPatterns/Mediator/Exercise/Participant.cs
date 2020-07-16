using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class Participant
    {
        private readonly Mediator _mediator;
        public int Value { get; set; }

        public Participant(Mediator mediator)
        {
            _mediator = mediator;
            mediator.Alert += Mediator_Alert;
        }

        private void Mediator_Alert(object sender, int e)
        {
            if (sender != this)
                Value += e;
        }

        public void Say(int n)
        {
            _mediator.Broadcast(this, n);
        }
    }
}
