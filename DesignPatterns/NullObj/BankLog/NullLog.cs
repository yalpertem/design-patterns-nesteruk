using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObj.BankLog
{
    public class NullLog : ILog
    {
        public void Info(string msg)
        {
        }

        public void Warn(string msg)
        {
        }
    }
}
