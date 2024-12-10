namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    internal class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Payment of ${amount} made using Credit Card.");
        }
    }
}