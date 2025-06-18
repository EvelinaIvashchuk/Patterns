using System;

namespace BehavioralPatterns.Command
{
    public class ConcreteCommand2 : Command
    {
        public ConcreteCommand2(Receiver receiver) : base(receiver) { }

        public override void Execute()
        {
            receiver.Action2();
        }
    }
}