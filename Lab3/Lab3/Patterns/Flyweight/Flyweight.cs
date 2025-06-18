using System;
using Lab3.Patterns.Common;

namespace Lab3.Patterns.Flyweight
{
    // Flyweight
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public string Operation(Car uniqueState)
        {
            string s = JsonSerializer.Serialize(_sharedState);
            string u = JsonSerializer.Serialize(uniqueState);
            return $"Flyweight: Displaying shared {s} and unique {u} state.";
        }
    }
}