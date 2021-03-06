using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP.Hierarchy
{
    public class PersonInfoBuilder<SELF>: PersonBuilder where SELF:PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }
    }
}
