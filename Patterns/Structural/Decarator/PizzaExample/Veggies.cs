namespace DesignPatterns.Patterns.Structural.Decarator.PizzaExample
{
    internal class Veggies : IToppingDecarator
    {
        private IBasePizza _basePizza;

        public Veggies(IBasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public int Cost => _basePizza.Cost + 50;
    }
}