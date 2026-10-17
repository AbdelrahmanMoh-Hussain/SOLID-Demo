using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.InterfaceSegregation
{
    internal class Scanner : IMachine
    {
        void IMachine.Print()
        {
            throw new NotImplementedException();
        }

        void IMachine.Scan()
        {
            Console.WriteLine("Scanning...");
        }
    }
}
