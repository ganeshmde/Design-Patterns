using DesignPatterns.Runner;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    internal class StartegyMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();

            PaymentContext context = new PaymentContext();
            context.SetPaymentStrategy(new CreditCardPayment());
            context.ProcessPayment(105.20);

            context.SetPaymentStrategy(new PayPalPayment());
            context.ProcessPayment(20.04);

            PrintEndLine();
        }
    }
}