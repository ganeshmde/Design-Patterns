namespace DesignPatterns.Patterns.Structural.Bridge.Implementor
{
    internal interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}