using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight.RepeatingUserNames
{
    public class User
    {
        private string _fullName;

        public User(string fullName)
        {
            _fullName = fullName;
        }
    }
}
