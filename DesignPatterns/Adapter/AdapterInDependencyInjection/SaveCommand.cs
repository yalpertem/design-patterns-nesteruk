using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.AdapterInDependencyInjection
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file.");
        }
    }
}
