namespace DesignPatterns.Patterns.Structural.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double money);
    }

    public class ThirdPartyPay
    {
        public void MakePayment(double money)
        {
            Console.WriteLine($"Processing Payment of ${money} through third party");
        }
    }

    public class PaymentAdapter : IPaymentProcessor
    {
        private ThirdPartyPay _thirdPartyPay;

        public PaymentAdapter(ThirdPartyPay thirdPartyPay)
        {
            _thirdPartyPay = thirdPartyPay;
        }

        public void ProcessPayment(double money)
        {
            _thirdPartyPay.MakePayment(money);
        }
    }
}