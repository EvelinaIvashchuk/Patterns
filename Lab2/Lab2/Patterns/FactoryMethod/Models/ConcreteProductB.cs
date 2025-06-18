using System;

namespace Lab2.Patterns.FactoryMethod.Models
{
    public class ConcreteProductB : Product
    {
        public override string Operation()
        {
            return "Result of ConcreteProductB";
        }
    }
}