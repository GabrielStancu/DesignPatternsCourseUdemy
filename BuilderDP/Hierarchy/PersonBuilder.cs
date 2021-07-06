using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP.Hierarchy
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build() 
        {
            return person; 
        }
    }
}
