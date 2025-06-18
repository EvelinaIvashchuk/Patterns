using System;

namespace BehavioralPatterns.TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB: PrimitiveOperation2");
        }

        protected override void PrimitiveOperation3()
        {
            Console.WriteLine("ConcreteClassB: PrimitiveOperation3");
        }
    }
}