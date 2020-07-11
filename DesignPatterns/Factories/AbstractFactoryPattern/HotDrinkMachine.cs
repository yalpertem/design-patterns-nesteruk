using System;
using System.Collections.Generic;

namespace DesignPatterns.Factories.AbstractFactoryPattern
{
    public class HotDrinkMachine
    {
        private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var drinkName = Enum.GetName(typeof(AvailableDrink), drink);
                var typeName = $"DesignPatterns.Factories.AbstractFactoryPattern.{drinkName}Factory";
                var factory = (IHotDrinkFactory)Activator.CreateInstance(Type.GetType(typeName));
                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}