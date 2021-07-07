using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is nice but I'd prefer it with milk.");
        }
    }
}
