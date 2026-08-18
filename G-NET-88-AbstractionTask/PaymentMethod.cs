using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_AbstractionTask
{
    public abstract class PaymentMethod
    {
        public decimal Amount { get; set; }

        public PaymentMethod(decimal amount)
        {
            Amount = amount;
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"    Receipt: {this.GetType().Name} paid ${Amount}");
        }

        public abstract void Pay();
    }
}
