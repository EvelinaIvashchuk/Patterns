using System;
using System.Collections.Generic;
using Lab3.Patterns.Adapter;
using Lab3.Patterns.Bridge;
using Lab3.Patterns.Composite;
using Lab3.Patterns.Decorator;
using Lab3.Patterns.Facade;
using Lab3.Patterns.Flyweight;
using Lab3.Patterns.Proxy;
using Lab3.Patterns.Common;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Structural Design Patterns:\n");

            // 1. Adapter Pattern
            Console.WriteLine("1. Adapter Pattern:");
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.Request());
            Console.WriteLine();

            // 2. Bridge Pattern
            Console.WriteLine("2. Bridge Pattern:");
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementationA());
            Console.WriteLine(abstraction.Operation());
            abstraction = new RefinedAbstraction(new ConcreteImplementationB());
            Console.WriteLine(abstraction.Operation());
            Console.WriteLine();

            // 3. Composite Pattern
            Console.WriteLine("3. Composite Pattern:");
            Leaf leaf1 = new Leaf("1");
            Leaf leaf2 = new Leaf("2");
            Leaf leaf3 = new Leaf("3");
            Leaf leaf4 = new Leaf("4");

            Composite branch1 = new Composite("Branch1");
            branch1.Add(leaf1);
            branch1.Add(leaf2);

            Composite branch2 = new Composite("Branch2");
            branch2.Add(leaf3);
            branch2.Add(leaf4);

            Composite tree = new Composite("Tree");
            tree.Add(branch1);
            tree.Add(branch2);

            Console.WriteLine($"Leaf: {leaf1.Operation()}");
            Console.WriteLine($"Branch: {branch1.Operation()}");
            Console.WriteLine($"Tree: {tree.Operation()}");
            Console.WriteLine();

            // 4. Decorator Pattern
            Console.WriteLine("4. Decorator Pattern:");
            IComponent component = new ConcreteComponent();
            Console.WriteLine($"Basic component: {component.Operation()}");

            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(component);
            Console.WriteLine($"Decorator A: {decoratorA.Operation()}");

            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
            Console.WriteLine($"Decorator B wrapping A: {decoratorB.Operation()}");
            Console.WriteLine();

            // 5. Facade Pattern
            Console.WriteLine("5. Facade Pattern:");
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Console.WriteLine(facade.Operation());
            Console.WriteLine();

            // 6. Flyweight Pattern
            Console.WriteLine("6. Flyweight Pattern:");
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "Black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "Red" },
                new Car { Company = "BMW", Model = "M5", Color = "Red" },
                new Car { Company = "BMW", Model = "X6", Color = "White" }
            );

            factory.ListFlyweights();

            AddCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "Red"
            });

            AddCarToPoliceDatabase(factory, new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "Red"
            });

            factory.ListFlyweights();
            Console.WriteLine();

            // 7. Proxy Pattern
            Console.WriteLine("7. Proxy Pattern:");
            RealSubject realSubject = new RealSubject();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with an authorized proxy:");
            Proxy proxy = new Proxy(realSubject, true);
            ClientCode(proxy);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with an unauthorized proxy:");
            proxy = new Proxy(realSubject, false);
            ClientCode(proxy);
    }

    // Helper method for Flyweight pattern
    private static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("\nClient: Adding a car to database.");

        var flyweight = factory.GetFlyweight(new Car
        {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });

        // The client code either stores or calculates extrinsic state and passes it
        // to the flyweight's methods.
        flyweight.Operation(car);
    }

    // Helper method for Proxy pattern
    private static void ClientCode(ISubject subject)
    {
        Console.WriteLine(subject.Request());
    }
}
