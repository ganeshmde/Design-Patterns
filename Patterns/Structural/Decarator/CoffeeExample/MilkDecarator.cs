using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Decarator.CoffeeExample
{
    internal class MilkDecarator : ICoffeeDecarator
    {
        public ICoffee _coffee;

        public MilkDecarator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public override string getDescription()
        {
            return _coffee.getDescription() + ", Milk";
        }

        public override double getCost()
        {
            return _coffee.getCost() + 0.7;
        }
    }
}