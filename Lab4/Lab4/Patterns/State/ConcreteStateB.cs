using System;

namespace BehavioralPatterns.State
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            Console.WriteLine("State B handles the request");
            context.State = new ConcreteStateA();
        }
    }
}