using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.InterfaceSegregation
{
    internal class OfficeMachine : IPrinter, IScanner
    {
        void IPrinter.Print()
        {
            Console.WriteLine("Printing...");
        }
        void IScanner.Scan()
        {
            Console.WriteLine("Scanning...");
        }
    {
    }
}
