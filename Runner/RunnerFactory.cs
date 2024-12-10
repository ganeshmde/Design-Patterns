using DesignPatterns.Patterns.Behavioural.Observer;
using DesignPatterns.Patterns.Behavioural.Strategy;
using DesignPatterns.Patterns.Creational.Factory;
using DesignPatterns.Patterns.Creational.Prototype;
using DesignPatterns.Patterns.Creational.Singleton;
using DesignPatterns.Patterns.Structural.Adapter;
using DesignPatterns.Patterns.Structural.Bridge;
using DesignPatterns.Patterns.Structural.Decarator;

namespace DesignPatterns.Runner
{
    internal class RunnerFactory
    {
        public List<IRunner> CreateRunners()
        {
            return new List<IRunner>
            {
                new SingletonMain(),
                new FactoryMain(),
                new PrototypeMain(),
                new DecaratorMain(),
                new AdapterMain(),
                new BridgeMain(),
                new StartegyMain(),
                new ObserverMain()
            };
        }
    }
}