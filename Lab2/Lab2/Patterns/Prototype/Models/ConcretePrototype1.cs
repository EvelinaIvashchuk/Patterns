using System;

namespace Lab2.Patterns.Prototype.Models
{
    public class ConcretePrototype1 : Prototype
    {
        public string Field1 { get; set; }

        public ConcretePrototype1(string id, string field1) : base(id)
        {
            Field1 = field1;
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id, Field1);
        }
    }
}