using System;

namespace BehavioralPatterns.Iterator
{
    public interface Aggregate
    {
        Iterator CreateIterator();
    }
}