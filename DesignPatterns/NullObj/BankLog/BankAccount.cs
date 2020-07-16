using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObj.BankLog
{
    public class BankAccount
    {
        private ILog _log;
        private int _balance;

        public BankAccount(ILog log)
        {
            _log = log;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            _log.Info($"Deposited {amount}. Balance: {_balance}");
        }
    }
}
