using DesignPatterns.Runner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Creational.Singleton
{
    internal class SingletonMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();
            var singleton1 = Singleton.GetInstance;
            var singleton2 = Singleton.GetInstance;
            Console.WriteLine($"Singleton1 == Singleton2, Result: {singleton1.Equals(singleton2)}");
            PrintEndLine();
        }
    }
}