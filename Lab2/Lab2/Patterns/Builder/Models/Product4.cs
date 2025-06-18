using System;
using System.Collections.Generic;

namespace Lab2.Patterns.Builder.Models
{
    public class Product4
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            return $"Product parts: {string.Join(", ", _parts)}";
        }
    }
}