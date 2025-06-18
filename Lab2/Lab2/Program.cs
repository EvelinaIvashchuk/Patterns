using System;
using System.Collections.Generic;
using Lab2.Patterns.Singleton;
using Lab2.Patterns.FactoryMethod.Creators;
using Lab2.Patterns.FactoryMethod.Models;
using Lab2.Patterns.AbstractFactory.Interfaces;
using Lab2.Patterns.AbstractFactory.Factories;
using Lab2.Patterns.Builder.Builders;
using Lab2.Patterns.Builder.Interfaces;
using Lab2.Patterns.Builder.Models;
using Lab2.Patterns.Prototype.Models;

namespace Lab2
{
    // Main program to demonstrate all patterns
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating 5 Creational Design Patterns\n");

            // 1. Singleton Pattern
            Console.WriteLine("1. Singleton Pattern:");
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;

            Console.WriteLine($"Singleton1 data: {singleton1.Data}");
            singleton1.Data = "Modified data";
            Console.WriteLine($"Singleton2 data after modification through Singleton1: {singleton2.Data}");
            Console.WriteLine($"Are both instances the same object? {ReferenceEquals(singleton1, singleton2)}");
            Console.WriteLine();

            // 2. Factory Method Pattern
            Console.WriteLine("2. Factory Method Pattern:");
            Console.WriteLine("App: Launched with ConcreteCreatorA");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("App: Launched with ConcreteCreatorB");
            ClientCode(new ConcreteCreatorB());
            Console.WriteLine();

            // 3. Abstract Factory Pattern
            Console.WriteLine("3. Abstract Factory Pattern:");
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientCode(new ConcreteFactory1());

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientCode(new ConcreteFactory2());
            Console.WriteLine();

            // 4. Builder Pattern
            Console.WriteLine("4. Builder Pattern:");
            var builder = new ConcreteBuilder();
            var director = new Director(builder);

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.WriteLine();

            // 5. Prototype Pattern
            Console.WriteLine("5. Prototype Pattern:");
            var p1 = new ConcretePrototype1("1", "Field1-Value");
            var p1Clone = p1.Clone() as ConcretePrototype1;

            Console.WriteLine($"Original prototype: Id={p1.Id}, Field1={p1.Field1}");
            Console.WriteLine($"Cloned prototype: Id={p1Clone.Id}, Field1={p1Clone.Field1}");

            var p2 = new ConcretePrototype2("2", "Field2-Value");
            var p2Clone = p2.Clone() as ConcretePrototype2;

            Console.WriteLine($"Original prototype: Id={p2.Id}, Field2={p2.Field2}");
            Console.WriteLine($"Cloned prototype: Id={p2Clone.Id}, Field2={p2Clone.Field2}");
            Console.ReadKey();
        }

        // Client code for Factory Method
        static void ClientCode(Creator creator)
        {
            Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{creator.SomeOperation()}");
        }

        // Client code for Abstract Factory
        static void ClientCode(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
