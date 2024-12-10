using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Decarator.CoffeeExample
{
    internal abstract class ICoffeeDecarator : ICoffee
    {
        public abstract double getCost();

        public abstract string getDescription();
    }
}