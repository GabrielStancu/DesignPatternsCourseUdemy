using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
