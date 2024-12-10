using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Decarator.CoffeeExample
{
    internal class BasicCoffee : ICoffee
    {
        public string getDescription()
        {
            return "Basic Coffee";
        }

        public double getCost()
        {
            return 20.0;
        }
    }
}