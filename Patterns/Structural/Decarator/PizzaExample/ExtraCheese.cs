namespace DesignPatterns.Patterns.Structural.Decarator.PizzaExample
{
    internal class ExtraCheese : IToppingDecarator
    {
        private IBasePizza basePizza;

        public ExtraCheese(IBasePizza basePizza)
        {
            this.basePizza = basePizza;
        }

        public int Cost => basePizza.Cost + 20;
    }
}