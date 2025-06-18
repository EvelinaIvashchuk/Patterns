using System;

namespace BehavioralPatterns.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            PrimitiveOperation3();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
        protected abstract void PrimitiveOperation3();
    }
}