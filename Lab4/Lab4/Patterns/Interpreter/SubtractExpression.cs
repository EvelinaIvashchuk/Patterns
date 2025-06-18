using System;

namespace BehavioralPatterns.Interpreter
{
    public class SubtractExpression : Expression
    {
        private Expression left;
        private Expression right;

        public SubtractExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpret(Context context)
        {
            return left.Interpret(context) - right.Interpret(context);
        }
    }
}