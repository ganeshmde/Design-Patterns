namespace DesignPatterns.Patterns.Structural.Decarator.CoffeeExample
{
    internal interface ICoffee
    {
        string getDescription();

        double getCost();

        virtual string GetDetails()
        {
            return $"{getDescription()}, Cost: ${getCost()}";
        }
    }
}