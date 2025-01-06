using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Interfaces
{
    internal class Mytype : IMytype
    {
        public int Id { get; set; }
        public void fun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
