using System;
using Lab2.Patterns.AbstractFactory.Interfaces;

namespace Lab2.Patterns.AbstractFactory.Products
{
    public class ConcreteAbstractProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Product B2";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            return $"B2 collaborating with {collaborator.UsefulFunctionA()}";
        }
    }
}