using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.DependencyInversion
{
    internal interface IDatabaseConnector
    {
        internal void Connect();
    }
}
