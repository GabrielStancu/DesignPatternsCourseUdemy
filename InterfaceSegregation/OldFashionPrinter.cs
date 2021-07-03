using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class OldFashionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
