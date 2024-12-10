using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Decarator.PizzaExample
{
    internal class Margherita : IBasePizza
    {
        public int Cost { get => 120; }
    }
}