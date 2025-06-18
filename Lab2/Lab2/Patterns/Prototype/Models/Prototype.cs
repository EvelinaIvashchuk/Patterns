using System;

namespace Lab2.Patterns.Prototype.Models
{
    public abstract class Prototype
    {
        public string Id { get; private set; }

        public Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}