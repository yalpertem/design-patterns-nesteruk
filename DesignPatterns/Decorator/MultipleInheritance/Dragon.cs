using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.MultipleInheritance
{
    public class Dragon : IBird, ILizard
    {
        private readonly Bird _bird;
        private readonly Lizard _lizard;
        private int _weight;

        public Dragon(Bird bird, Lizard lizard)
        {
            _bird = bird;
            _lizard = lizard;
        }

        public int Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                _bird.Weight = value;
                _lizard.Weight = value;
            }
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }

        public string Fly()
        {
            return _bird.Fly();
        }
    }
}
