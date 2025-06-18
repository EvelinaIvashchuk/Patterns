using System;

namespace BehavioralPatterns.Visitor
{
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("Visitor1 visited ElementA");
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("Visitor1 visited ElementB");
        }
    }
}