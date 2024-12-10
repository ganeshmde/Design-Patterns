using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Behavioural.Strategy
{
    internal class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy = null;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Payment Strategy not set.");
            }

            _paymentStrategy.Pay(amount);
        }
    }
}