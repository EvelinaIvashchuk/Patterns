using System;
using Lab2.Patterns.FactoryMethod.Models;

namespace Lab2.Patterns.FactoryMethod.Creators
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return $"Creator: {product.Operation()}";
        }
    }
}