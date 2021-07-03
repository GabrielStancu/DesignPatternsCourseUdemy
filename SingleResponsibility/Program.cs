using System;
using System.Diagnostics;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            Console.WriteLine(j);

            var p = new Persistance();
            var filename = @"C:\temp\journal.txt";
            p.Save(j, filename);
            Process.Start(filename);
        }
    }
}
