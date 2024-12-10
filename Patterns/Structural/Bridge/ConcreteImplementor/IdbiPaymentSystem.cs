using DesignPatterns.Patterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Patterns.Structural.Bridge.ConcreteImplementor
{
    internal class IdbiPaymentSystem : IPaymentSystem
    {
        public virtual void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using idbi bank gateway for {paymentSystem} payment system");
        }
    }
}