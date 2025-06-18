using System;

namespace Lab3.Patterns.Decorator
{
    // Concrete Component
    public class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}