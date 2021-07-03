using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }
}
