using DesignPatterns.Runner;

namespace DesignPatterns.Patterns.Structural.Adapter
{
    internal class AdapterMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();
            ThirdPartyPay thirdPartyPay = new ThirdPartyPay();
            IPaymentProcessor paymentProcessor = new PaymentAdapter(thirdPartyPay);
            paymentProcessor.ProcessPayment(150);
            PrintEndLine();
        }
    }
}