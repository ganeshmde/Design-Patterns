using DesignPatterns.Patterns.Structural.Decarator.CoffeeExample;
using DesignPatterns.Patterns.Structural.Decarator.PizzaExample;
using DesignPatterns.Runner;

namespace DesignPatterns.Patterns.Structural.Decarator
{
    internal class DecaratorMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();
            Console.WriteLine();
            Console.WriteLine("Decarator with Pizza Example");
            IBasePizza vegDelightPizza = new VegDelight();
            Console.WriteLine($"Veg Delight pizza cost: ${vegDelightPizza.Cost}");
            IBasePizza vegDelightPizzaWithExtraCheese = new ExtraCheese(vegDelightPizza);
            Console.WriteLine($"Veg Delight pizza cost with extra cheese: ${vegDelightPizzaWithExtraCheese.Cost}");
            IBasePizza vegDelightPizzaWithExtraCheeseAndVeggie = new Veggies(vegDelightPizzaWithExtraCheese);
            Console.WriteLine($"Veg Delight pizza cost with extra cheese and veggies: ${vegDelightPizzaWithExtraCheeseAndVeggie.Cost}");
            Console.WriteLine();

            Console.WriteLine("Decarator with Coffee Example");
            ICoffee basicCoffee = new BasicCoffee();
            Console.WriteLine(basicCoffee.GetDetails());
            basicCoffee = new MilkDecarator(basicCoffee);
            Console.WriteLine(basicCoffee.GetDetails());
            basicCoffee = new SugarDecarator(basicCoffee);
            Console.WriteLine(basicCoffee.GetDetails());
            Console.WriteLine();
            PrintEndLine();
        }
    }
}