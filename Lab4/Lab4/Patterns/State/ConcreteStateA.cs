using System;

namespace BehavioralPatterns.State
{
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("State A handles the request");
            context.State = new ConcreteStateB();
        }
    }
}