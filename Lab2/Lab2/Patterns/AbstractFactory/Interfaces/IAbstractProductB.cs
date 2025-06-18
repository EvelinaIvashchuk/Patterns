using System;

namespace Lab2.Patterns.AbstractFactory.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}