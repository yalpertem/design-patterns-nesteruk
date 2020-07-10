using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton.Monostate
{
    public class Ceo
    {
        private static string _name;
        private static int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}
