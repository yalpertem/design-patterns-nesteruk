using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento.Bank
{
    public class MementoToken
    {
        public int Balance { get; }

        public MementoToken(int balance)
        {
            Balance = balance;
        }
    }
}
