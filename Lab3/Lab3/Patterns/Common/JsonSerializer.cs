using System;
using System.Collections.Generic;

namespace Lab3.Patterns.Common
{
    // JSON Serializer for Flyweight pattern
    public static class JsonSerializer
    {
        public static string Serialize(object obj)
        {
            if (obj == null)
                return "null";

            var properties = obj.GetType().GetProperties();
            var pairs = new List<string>();

            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                if (value != null)
                {
                    pairs.Add($"\"{property.Name}\":\"{value}\"");
                }
            }

            return "{" + string.Join(",", pairs) + "}";
        }
    }
}