using System;

namespace BehavioralPatterns.ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 3)
            {
                Console.WriteLine($"ConcreteHandler3 handled request {request}");
            }
            else
            {
                Console.WriteLine($"Request {request} cannot be handled by any handler");
            }
        }
    }
}