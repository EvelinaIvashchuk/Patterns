using System;
using Lab2.Patterns.AbstractFactory.Interfaces;

namespace Lab2.Patterns.AbstractFactory.Products
{
    public class ConcreteAbstractProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "Product A2";
        }
    }
}