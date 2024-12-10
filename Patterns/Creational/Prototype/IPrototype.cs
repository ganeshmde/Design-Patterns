using System;

namespace DesignPatterns.Patterns.Creational.Prototype
{
    internal interface IPrototype<T> where T : class
    {
        T Clone();
    }
}