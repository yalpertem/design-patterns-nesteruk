using System;

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