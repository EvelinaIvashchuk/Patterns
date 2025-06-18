using System;
using System.Collections.Generic;

namespace BehavioralPatterns.Interpreter
{
    public class Context
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();

        public void SetVariable(string name, int value)
        {
            variables[name] = value;
        }

        public int GetVariable(string name)
        {
            return variables[name];
        }
    }
}