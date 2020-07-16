using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObj.BankLog
{
    public class ConsoleLog : ILog
    {
        public void Info(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Warn(string msg)
        {
            Console.WriteLine("WARNING:" + msg);
        }
    }
}
