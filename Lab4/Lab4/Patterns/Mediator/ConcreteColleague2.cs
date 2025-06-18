using System;

namespace BehavioralPatterns.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("Colleague2 sends: " + message);
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 receives: " + message);
        }
    }
}