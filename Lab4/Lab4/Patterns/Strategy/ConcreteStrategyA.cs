using System;

namespace BehavioralPatterns.Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Strategy A implemented");
        }
    }
}