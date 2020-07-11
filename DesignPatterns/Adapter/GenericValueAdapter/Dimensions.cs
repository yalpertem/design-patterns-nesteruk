using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.GenericValueAdapter
{
    public static class Dimensions
    {
        public class Two : IInteger
        {
            public int Value => 2;
        }

        public class Three : IInteger
        {
            public int Value => 3;
        }
    }
}
