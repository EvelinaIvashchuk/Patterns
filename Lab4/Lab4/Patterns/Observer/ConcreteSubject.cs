using System;

namespace BehavioralPatterns.Observer
{
    public class ConcreteSubject : Subject
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
    }
}