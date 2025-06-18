using System;

namespace Lab3.Patterns.Adapter
{
    // Adaptee (the class that needs adapting)
    public class Adaptee
    {
        public string SpecificRequest()
        {
            return "Specific request from Adaptee";
        }
    }
}