using System;

namespace BehavioralPatterns.TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA: PrimitiveOperation2");
        }

        protected override void PrimitiveOperation3()
        {
            Console.WriteLine("ConcreteClassA: PrimitiveOperation3");
        }
    }
}