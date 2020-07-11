using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.AdapterInDependencyInjection
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a file.");
        }
    }
}
