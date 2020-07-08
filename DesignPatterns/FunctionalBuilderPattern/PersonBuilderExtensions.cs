using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FunctionalBuilderPattern
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
        {
            return builder.Do(p => p.Position = position);
        }
    }
}
