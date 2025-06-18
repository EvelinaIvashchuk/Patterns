using System;
using Lab2.Patterns.FactoryMethod.Models;

namespace Lab2.Patterns.FactoryMethod.Creators
{
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}