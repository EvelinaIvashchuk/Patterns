using System;
using Lab2.Patterns.AbstractFactory.Interfaces;
using Lab2.Patterns.AbstractFactory.Products;

namespace Lab2.Patterns.AbstractFactory.Factories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteAbstractProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteAbstractProductB1();
        }
    }
}