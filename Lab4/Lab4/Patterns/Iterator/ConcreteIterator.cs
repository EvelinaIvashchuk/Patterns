using System;

namespace BehavioralPatterns.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public string First()
        {
            return aggregate[0];
        }

        public string Next()
        {
            string ret = string.Empty;
            current++;
            if (!IsDone())
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public string CurrentItem()
        {
            return aggregate[current];
        }
    }
}