using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Interfaces
{
    internal interface IMytype
    {
        // 1. Signature of the property
        public int Id { get; set; }
        // 2. Signature of the method (name, return type, parameters)
        public void fun();
        // 3. Default implementated method
        public void Print()
        {
            Console.WriteLine("Fully implemnted method");
        }
    }
}
