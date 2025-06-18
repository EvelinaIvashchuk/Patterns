using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private List<string> items = new List<string>();

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public string this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public void AddItem(string item)
        {
            items.Add(item);
        }
    }
}