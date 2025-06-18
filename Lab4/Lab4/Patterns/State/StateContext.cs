using System;

namespace BehavioralPatterns.State
{
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State changed");
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}