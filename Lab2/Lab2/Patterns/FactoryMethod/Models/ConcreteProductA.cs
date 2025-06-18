using System;

namespace Lab2.Patterns.FactoryMethod.Models
{
    public class ConcreteProductA : Product
    {
        public override string Operation()
        {
            return "Result of ConcreteProductA";
        }
    }
}