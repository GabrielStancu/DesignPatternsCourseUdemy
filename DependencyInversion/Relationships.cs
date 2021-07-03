using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversion
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person From, Relationship R, Person To)> _relationships =
            new List<(Person From, Relationship R, Person To)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            _relationships.Add((parent, Relationship.Parent, child));
            _relationships.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var r in _relationships.Where(
                    x => x.From.Name == name &&
                         x.R == Relationship.Parent
                ))
            {
                yield return r.To;
            }
        }
    }
}
