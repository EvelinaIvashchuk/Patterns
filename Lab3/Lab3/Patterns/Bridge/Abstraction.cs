using System;

namespace Lab3.Patterns.Bridge
{
    // Abstraction
    public abstract class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"Abstraction: {_implementation.OperationImplementation()}";
        }
    }
}