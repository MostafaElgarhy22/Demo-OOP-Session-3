using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Override
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }
        public void Myfun01()
        {
            Console.WriteLine("I am Parent");
        }
        public virtual void Myfun02()
        {
            Console.WriteLine($" A = {A}");
        }
    }

    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        // static Binding[Early Binding]
        // Happen at compilation time
        // Compiler will bind the function call to based on the reference type not object.
        public new void Myfun01()
        {
            Console.WriteLine("I am Child");
        }
        // Dynamic Binding[Late Binding]
        // Happen at runtime
        // Clr will bind the function call to based on the object type not reference.
        public override void Myfun02()
        {
            Console.WriteLine($" B = {B}");
        }

    }
       
}
