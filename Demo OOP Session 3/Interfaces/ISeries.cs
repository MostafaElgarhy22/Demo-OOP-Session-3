using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Interfaces
{
    internal interface ISeries
    {
        public int Current { get; set; } // Signature of the property
        public int GetNext();

        public void Reset();

    }
}
