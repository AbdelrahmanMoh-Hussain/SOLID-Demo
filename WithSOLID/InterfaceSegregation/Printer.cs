using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.InterfaceSegregation
{
    internal class Printer : IMachine
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public void Scan() // This method is not implemented in the Printer class
        {
            throw new NotImplementedException();
        }
    {
    }
}
