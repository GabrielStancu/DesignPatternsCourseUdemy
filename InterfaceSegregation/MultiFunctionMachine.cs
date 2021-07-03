using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;
        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }
}
