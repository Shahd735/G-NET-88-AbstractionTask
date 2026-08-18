using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_AbstractionTask
{
    public class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base(amount)
        {
        }

        public override void Pay()
        {
            Console.WriteLine($"Paying {Amount} in Cash");
        }
    }
}
