using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.AdapterInDependencyInjection
{
    public class Button
    {
        private readonly ICommand _command;
        private readonly string _name;

        public Button(ICommand command, string name)
        {
            _command = command;
            _name = name;
        }

        public void Click()
        {
            _command.Execute();
        }

        public string PrintMe()
        {
            return _name;
        }
    }
}
