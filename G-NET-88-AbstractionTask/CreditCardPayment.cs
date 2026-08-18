using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_AbstractionTask
{
    public class CreditCardPayment : PaymentMethod, IRefundable
    {
        public CreditCardPayment(decimal amount) : base(amount)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} With Credit Card");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunding {Amount} To Credit Card");
        }
    }
}
