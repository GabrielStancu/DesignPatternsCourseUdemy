using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
