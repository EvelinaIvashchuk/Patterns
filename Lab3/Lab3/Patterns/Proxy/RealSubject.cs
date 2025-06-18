using System;

namespace Lab3.Patterns.Proxy
{
    // Real Subject
    public class RealSubject : ISubject
    {
        public string Request()
        {
            return "RealSubject: Handling Request.";
        }
    }
}