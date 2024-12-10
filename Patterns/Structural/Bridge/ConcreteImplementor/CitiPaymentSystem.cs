using DesignPatterns.Patterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Patterns.Structural.Bridge.ConcreteImplementor
{
    internal class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using citi bank gateway for {paymentSystem} payment system");
        }
    }
}