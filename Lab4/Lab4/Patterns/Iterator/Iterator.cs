using System;

namespace BehavioralPatterns.Iterator
{
    public interface Iterator
    {
        string First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}