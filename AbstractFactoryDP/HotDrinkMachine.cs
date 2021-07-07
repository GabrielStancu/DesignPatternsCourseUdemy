using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class HotDrinkMachine
    {
        //public enum AvailableDrink
        //{
        //    Coffee, 
        //    Tea
        //}

        //private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
        //    new Dictionary<AvailableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(
        //            Type.GetType("AbstractFactoryDP." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        private List<(string DrinkName, IHotDrinkFactory DrinkFactory)> factories = 
            new List<(string DrinkName, IHotDrinkFactory DrinkFactory)>();

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) &&
                    !t.IsInterface)
                {
                    factories.Add((
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)
                        ));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            for (int index = 0; index < factories.Count; index++)
            {
                var tuple = factories[index];
                Console.WriteLine($"{index}: {tuple.DrinkName}");
            }

            while(true)
            {
                string s;
                if((s = Console.ReadLine()) != null &&
                    int.TryParse(s, out int i) &&
                    i >= 0 && i < factories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();

                    if(s != null && 
                        int.TryParse(s, out int amount) &&
                        amount > 0)
                    {
                        return factories[i].DrinkFactory.Prepare(amount);
                    }
                }

                Console.WriteLine("Incorrect input, try again!");
            }
        }
    }
}
