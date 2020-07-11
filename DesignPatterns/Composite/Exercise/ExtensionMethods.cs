using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite.Exercise
{
    public static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int result = 0;
            foreach (var c in containers)
                foreach (var i in c)
                    result += i;
            return result;
        }
    }
}
