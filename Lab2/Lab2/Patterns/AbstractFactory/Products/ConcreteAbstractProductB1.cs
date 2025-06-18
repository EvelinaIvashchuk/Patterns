using System;
using Lab2.Patterns.AbstractFactory.Interfaces;

namespace Lab2.Patterns.AbstractFactory.Products
{
    public class ConcreteAbstractProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Product B1";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            return $"B1 collaborating with {collaborator.UsefulFunctionA()}";
        }
    }
}