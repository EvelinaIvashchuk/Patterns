using System;

namespace Lab3.Patterns.Composite
{
    // Component
    public abstract class Component
    {
        public string Name { get; set; }

        public Component(string name)
        {
            Name = name;
        }

        public abstract string Operation();
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return false;
        }
    }
}