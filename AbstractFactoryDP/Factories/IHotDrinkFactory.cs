using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
