using System;

namespace BehavioralPatterns.Visitor
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}