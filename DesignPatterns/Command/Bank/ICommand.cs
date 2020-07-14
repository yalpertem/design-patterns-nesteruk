using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.Bank
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}
