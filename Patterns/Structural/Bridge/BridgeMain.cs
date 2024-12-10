using DesignPatterns.Patterns.Structural.Bridge.Abstraction;
using DesignPatterns.Patterns.Structural.Bridge.ConcreteImplementor;
using DesignPatterns.Patterns.Structural.Bridge.RefinedAbstraction;
using DesignPatterns.Runner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Structural.Bridge
{
    internal class BridgeMain : IRunner
    {
        public override void Run()
        {
            PrintStartLine();
            Payment order = new CardPayment();
            order._paymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._paymentSystem = new IdbiPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._paymentSystem = new CitiPaymentSystem();
            order.MakePayment();
            PrintEndLine();
        }
    }
}