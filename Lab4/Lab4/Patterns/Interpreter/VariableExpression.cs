using System;

namespace BehavioralPatterns.Interpreter
{
    public class VariableExpression : Expression
    {
        private string name;

        public VariableExpression(string name)
        {
            this.name = name;
        }

        public override int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}