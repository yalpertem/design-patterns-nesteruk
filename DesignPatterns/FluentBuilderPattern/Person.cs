﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FluentBuilderPattern
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public static Builder New => new Builder();

        public Person()
        {
        }

        public Person(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
