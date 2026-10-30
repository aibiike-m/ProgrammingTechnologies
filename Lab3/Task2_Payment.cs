using System;

namespace programming_tecnologies
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }

    public class BankTransfer : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }

    public static class Task2_PaymentRunner
    {
        public static void Run()
        {
            IPaymentMethod payment1 = new CreditCard();
            IPaymentMethod payment2 = new PayPal();
            IPaymentMethod payment3 = new BankTransfer();

            payment1.Pay(150.0m);
            payment2.Pay(75.5m);
            payment3.Pay(300.0m);
        }
    }
}