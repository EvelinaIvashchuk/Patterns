using System;

namespace BehavioralPatterns.Interpreter
{
    public abstract class Expression
    {
        public abstract int Interpret(Context context);
    }
}