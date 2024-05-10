using System;
namespace Command
{
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = - 1000;

        public void Deposit(double amount)
        {
            Balance += amount; //Balance = Balance + amount;
            Console.WriteLine($"{amount} Euros have been deposited into the account.");
        }

        public void Withdraw(double amount)
        {
            if (Balance + OverdraftLimit < amount)
            {
                Console.WriteLine($"Your request:" + 
                    $"\t€{amount}" +
                    "\n" +
                    $"Surpasses the current withdrawal limit:" + 
                    $"\t€{Balance + OverdraftLimit}." + 
                    "Insufficient funds.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount} Euros have been withdrawn from the account. The new balance is {Balance} Euros.");
        }

        public override string ToString()
        {
            return $"Account balance: {Balance} Euros, Overdraft limit: {OverdraftLimit} Euros";
        }
    }
}

