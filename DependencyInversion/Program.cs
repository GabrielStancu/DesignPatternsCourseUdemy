using System;
using System.Linq;

namespace DependencyInversion
{
    class Program
    {
        public Program(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child named {p.Name}.");
            }
        }
        static void Main(string[] args)
        {
            var parent = new Person() { Name = "John" };
            var child1 = new Person() { Name = "Chris" };
            var child2 = new Person() { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Program(relationships);
        }
    }
}
