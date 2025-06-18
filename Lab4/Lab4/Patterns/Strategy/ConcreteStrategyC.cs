using System;

namespace BehavioralPatterns.Strategy
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Strategy C implemented");
        }
    }
}