using System;
using Lab2.Patterns.AbstractFactory.Interfaces;
using Lab2.Patterns.AbstractFactory.Products;

namespace Lab2.Patterns.AbstractFactory.Factories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteAbstractProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteAbstractProductB2();
        }
    }
}