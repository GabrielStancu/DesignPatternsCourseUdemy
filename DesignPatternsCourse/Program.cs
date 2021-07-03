using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductsFilter();
            Console.WriteLine("Green products:");
            foreach (var p in pf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"- {p.Name} is green.");
            }

            Console.WriteLine("Large blue items:");
            foreach (var p in pf.Filter(
                products,
                new AndSpecification(
                    new List<ISpecification<Product>>()
                    {
                        new ColorSpecification(Color.Blue),
                        new SizeSpecification(Size.Large)
                    }
                    )))
            {
                Console.WriteLine($"- {p.Name} is big and blue.");
            }
        }
    }
}
