using System;
using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Command;
using BehavioralPatterns.Interpreter;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Mediator;
using BehavioralPatterns.Memento;
using BehavioralPatterns.Observer;
using BehavioralPatterns.State;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.TemplateMethod;
using BehavioralPatterns.Visitor;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behavioral Design Patterns Demonstration\n");

            // 1. Chain of Responsibility Pattern
            Console.WriteLine("1. Chain of Responsibility Pattern:");
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);

            // Send requests to the chain
            handler1.HandleRequest(1);
            handler1.HandleRequest(2);
            handler1.HandleRequest(3);
            handler1.HandleRequest(4);
            Console.WriteLine();

            // 2. Command Pattern
            Console.WriteLine("2. Command Pattern:");
            Receiver receiver = new Receiver();
            Command.Command command1 = new ConcreteCommand1(receiver);
            Command.Command command2 = new ConcreteCommand2(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command1);
            invoker.ExecuteCommand();

            invoker.SetCommand(command2);
            invoker.ExecuteCommand();
            Console.WriteLine();

            // 3. Interpreter Pattern
            Console.WriteLine("3. Interpreter Pattern:");
            Interpreter.Context context = new Interpreter.Context();
            context.SetVariable("a", 10);
            context.SetVariable("b", 20);
            context.SetVariable("c", 30);

            // (a + b) - c
            Expression expression = new SubtractExpression(
                new AddExpression(
                    new VariableExpression("a"),
                    new VariableExpression("b")
                ),
                new VariableExpression("c")
            );

            Console.WriteLine("(a + b) - c = " + expression.Interpret(context));
            Console.WriteLine();

            // 4. Iterator Pattern
            Console.WriteLine("4. Iterator Pattern:");
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.AddItem("Item 1");
            aggregate.AddItem("Item 2");
            aggregate.AddItem("Item 3");
            aggregate.AddItem("Item 4");

            Iterator.Iterator iterator = aggregate.CreateIterator();
            Console.WriteLine("Iterating through collection:");
            for (string item = iterator.First(); !iterator.IsDone(); item = iterator.Next())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 5. Mediator Pattern
            Console.WriteLine("5. Mediator Pattern:");
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("Hello from Colleague1");
            colleague2.Send("Hello from Colleague2");
            Console.WriteLine();

            // 6. Memento Pattern
            Console.WriteLine("6. Memento Pattern:");
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.State = "State 1";
            Console.WriteLine("Current state: " + originator.State);

            // Save state
            caretaker.Memento = originator.CreateMemento();

            // Change state
            originator.State = "State 2";
            Console.WriteLine("Current state: " + originator.State);

            // Restore state
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine("Restored state: " + originator.State);
            Console.WriteLine();

            // 7. Observer Pattern
            Console.WriteLine("7. Observer Pattern:");
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.State = "New State";
            subject.Notify();
            Console.WriteLine();

            // 8. State Pattern
            Console.WriteLine("8. State Pattern:");
            State.Context context8 = new State.Context(new ConcreteStateA());

            context8.Request(); // Handles request in state A
            context8.Request(); // Handles request in state B
            context8.Request(); // Handles request in state A
            Console.WriteLine();

            // 9. Strategy Pattern
            Console.WriteLine("9. Strategy Pattern:");
            Strategy.Context context9 = new Strategy.Context(new ConcreteStrategyA());
            context9.ExecuteStrategy();

            context9.SetStrategy(new ConcreteStrategyB());
            context9.ExecuteStrategy();

            context9.SetStrategy(new ConcreteStrategyC());
            context9.ExecuteStrategy();
            Console.WriteLine();

            // 10. Template Method Pattern
            Console.WriteLine("10. Template Method Pattern:");
            AbstractClass templateA = new ConcreteClassA();
            AbstractClass templateB = new ConcreteClassB();

            Console.WriteLine("Template A:");
            templateA.TemplateMethod();

            Console.WriteLine("\nTemplate B:");
            templateB.TemplateMethod();
            Console.WriteLine();

            // 11. Visitor Pattern
            Console.WriteLine("11. Visitor Pattern:");
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

            objectStructure.Accept(visitor1);
            objectStructure.Accept(visitor2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
