using System;

namespace Lab2.Patterns.Prototype.Models
{
    public class ConcretePrototype2 : Prototype
    {
        public string Field2 { get; set; }

        public ConcretePrototype2(string id, string field2) : base(id)
        {
            Field2 = field2;
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id, Field2);
        }
    }
}