using System;

namespace BehavioralPatterns.Observer
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(string name)
        {
            this.name = name;
        }

        public override void Update()
        {
            Console.WriteLine($"{name} received update notification");
        }
    }
}