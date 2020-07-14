using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.Command.Bank
{
    public class BankAccount
    {
        public int Balance { get; private set; }
        private const int _overdraftLimit = -500;

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now ${Balance}");
        }

        public bool Withdraw(int amount)
        {
            if (Balance - amount >= _overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now ${Balance}");
                return true;
            }
            return false;
        }
    }
}
