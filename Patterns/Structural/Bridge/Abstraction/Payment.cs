using DesignPatterns.Patterns.Structural.Bridge.Implementor;

namespace DesignPatterns.Patterns.Structural.Bridge.Abstraction
{
    internal abstract class Payment
    {
        public IPaymentSystem _paymentSystem;

        public abstract void MakePayment();
    }
}