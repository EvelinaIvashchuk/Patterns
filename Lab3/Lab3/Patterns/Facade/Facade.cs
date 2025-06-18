using System;

namespace Lab3.Patterns.Facade
{
    // Facade
    public class Facade
    {
        protected Subsystem1 _subsystem1;
        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += _subsystem1.Operation1() + "\n";
            result += _subsystem2.Operation1() + "\n";
            result += "Facade orders subsystems to perform the action:\n";
            result += _subsystem1.OperationN() + "\n";
            result += _subsystem2.OperationZ();
            return result;
        }
    }
}