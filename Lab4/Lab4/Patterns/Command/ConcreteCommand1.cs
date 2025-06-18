using System;

namespace BehavioralPatterns.Command
{
    public class ConcreteCommand1 : Command
    {
        public ConcreteCommand1(Receiver receiver) : base(receiver) { }

        public override void Execute()
        {
            receiver.Action1();
        }
    }
}