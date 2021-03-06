﻿namespace DesignPatterns.Builder.FunctionalBuilderPattern
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs(this PersonBuilder builder, string position)
        {
            return builder.Do(p => p.Position = position);
        }
    }
}