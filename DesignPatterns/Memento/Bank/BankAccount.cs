using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento.Bank
{
    public class BankAccount
    {
        private int _balance;

        private readonly List<MementoToken> _changes = new List<MementoToken>();
        private int _current;

        public BankAccount(int balance)
        {
            _balance = balance;
            _changes.Add(new MementoToken(_balance));
        }

        public MementoToken Deposit(int amount)
        {
            _balance += amount;
            var m = new MementoToken(_balance);
            _changes.Add(m);
            _current++;
            return m;
        }

        public MementoToken Undo()
        {
            if (_current > 0)
            {
                var m = _changes[--_current];
                _balance = m.Balance;
                return m;
            }
            return null;
        }

        public MementoToken Redo()
        {
            if (_current + 1 < _changes.Count)
            {
                var m = _changes[++_current];
                _balance = m.Balance;
                return m;
            }
            return null;
        }

        public MementoToken Restore(MementoToken token)
        {
            if (token != null)
            {
                _balance = token.Balance;
                _changes.Add(token);
                return token;
            }
            return null;
        }

        public override string ToString()
        {
            return $"balance:{_balance}";
        }
    }
}
