using System;

namespace Lab3.Patterns.Bridge
{
    // Concrete Implementation A
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA";
        }
    }
}