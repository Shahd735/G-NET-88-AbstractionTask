

using G_NET_88_AbstractionTask;

internal class Program
{
    static void Main(string[] args)
    {
        PaymentMethod[] payments = new PaymentMethod[]
            {
                new CreditCardPayment(1500m),
                new CashPayment(300m)
            };

        for (int i = 0; i < payments.Length; i++)
        {
            var payment = payments[i];

            payment.Pay();
            payment.PrintReceipt();

            if (payment is IRefundable refundablePayment)
            {
                refundablePayment.Refund();
            }

            if (i < payments.Length - 1)
            {
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}


