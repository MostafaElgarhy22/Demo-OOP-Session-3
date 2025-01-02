using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Interfaces
{
    internal class Seriesbytwo : ISeries
    {
        public int Current { get; set; }
        public int GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
