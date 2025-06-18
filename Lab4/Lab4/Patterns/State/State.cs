using System;

namespace BehavioralPatterns.State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}