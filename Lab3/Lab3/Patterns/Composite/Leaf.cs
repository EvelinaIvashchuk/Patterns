using System;

namespace Lab3.Patterns.Composite
{
    // Leaf
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override string Operation()
        {
            return $"Leaf {Name}";
        }
    }
}