using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP.Hierarchy
{
    public class PersonJobBuilder<SELF>: PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF: PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
