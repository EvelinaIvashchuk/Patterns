using System;

namespace BehavioralPatterns.Memento
{
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State set to: " + state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}