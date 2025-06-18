using System;
using Lab2.Patterns.Builder.Interfaces;
using Lab2.Patterns.Builder.Models;

namespace Lab2.Patterns.Builder.Builders
{
    public class ConcreteBuilder : IBuilder
    {
        private Product4 _product = new Product4();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product4();
        }

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartB");
        }

        public void BuildPartC()
        {
            _product.Add("PartC");
        }

        public Product4 GetProduct()
        {
            Product4 result = _product;
            Reset();
            return result;
        }
    }
}