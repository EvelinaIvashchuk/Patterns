using System;

namespace Lab3.Patterns.Adapter
{
    // Adapter
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Request()
        {
            return $"Adapter: {_adaptee.SpecificRequest()}";
        }
    }
}