using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.LiskovSubstitution
{
    internal class Square : Rectangle
    {
        public Square(decimal side) : base(side, side)
        {
            
        }


    }
}
