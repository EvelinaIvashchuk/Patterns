using System;

namespace BehavioralPatterns.Strategy
{
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.AlgorithmInterface();
        }
    }
}