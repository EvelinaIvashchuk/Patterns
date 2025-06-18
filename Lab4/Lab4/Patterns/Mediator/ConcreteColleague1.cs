using System;

namespace BehavioralPatterns.Mediator
{
    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("Colleague1 sends: " + message);
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 receives: " + message);
        }
    }
}