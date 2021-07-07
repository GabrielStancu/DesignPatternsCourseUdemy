using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
