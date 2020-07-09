using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    /// <summary>
    /// HotDrinkMachine that does not violate Open-Closed Principle
    /// </summary>
    public class HotDrinkMachine
    {
        private List<Tuple<string, IHotDrinkFactory>> factories =
            new List<Tuple<string, IHotDrinkFactory>>();


        public HotDrinkMachine()
        {
            var typesInAssembly = typeof(HotDrinkMachine).Assembly.GetTypes();
            foreach (var t in typesInAssembly)
            {
                if (!t.IsInterface && !typeof(IHotDrinkFactory).IsAssignableFrom(t))
                {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeRandomDrink(int amount)
        {
            var rand = new Random().Next(0, factories.Count);
            return factories[rand].Item2.Prepare(amount);
        }
    }
}
