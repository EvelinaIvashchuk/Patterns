using System;

namespace Lab3.Patterns.Facade
{
    // Subsystem 1
    public class Subsystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!";
        }

        public string OperationN()
        {
            return "Subsystem1: Go!";
        }
    }
}