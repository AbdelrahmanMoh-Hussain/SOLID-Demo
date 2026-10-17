using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.InterfaceSegregation
{
    internal class Printer : IPrinter
    {
        void IPrinter.Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
