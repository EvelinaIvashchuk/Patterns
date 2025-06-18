using System;

namespace BehavioralPatterns.Strategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Strategy B implemented");
        }
    }
}