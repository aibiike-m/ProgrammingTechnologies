using System;

namespace programming_tecnologies
{
    public abstract class BankAccount
    {
        public decimal Balance { get; protected set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: {amount}, New balance: {Balance}");
            }
        }

        public abstract void Withdraw(decimal amount);
    }

    public class SavingsAccount : BankAccount
    {
        private decimal minBalance = 100m;

        public SavingsAccount(decimal initialBalance) : base(initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= minBalance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn from savings: {amount}, Remaining: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal denied: Minimum balance limit reached.");
            }
        }
    }

    public class CheckingAccount : BankAccount
    {
        private decimal fee = 10m;

        public CheckingAccount(decimal initialBalance) : base(initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            decimal totalAmount = amount + fee;
            if (Balance >= totalAmount)
            {
                Balance -= totalAmount;
                Console.WriteLine($"Withdrawn from checking: {amount} (Fee: {fee}), Remaining: {Balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal denied: Insufficient funds including fee.");
            }
        }
    }

    public static class Task1_BankAccountRunner
    {
        public static void Run()
        {
            SavingsAccount savings = new SavingsAccount(500m);
            savings.Withdraw(300m);
            savings.Withdraw(200m);

            CheckingAccount checking = new CheckingAccount(200m);
            checking.Withdraw(50m);
        }
    }
}