using DesignPatterns.Patterns.Structural.Bridge.Abstraction;
using DesignPatterns.Patterns.Structural.Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Bridge.RefinedAbstraction
{
    internal class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _paymentSystem.ProcessPayment("NetBanking");
        }
    }
}