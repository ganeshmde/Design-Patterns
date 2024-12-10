using DesignPatterns.Patterns.Structural.Bridge.Abstraction;

namespace DesignPatterns.Patterns.Structural.Bridge.RefinedAbstraction
{
    internal class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _paymentSystem.ProcessPayment("Card");
        }
    }
}