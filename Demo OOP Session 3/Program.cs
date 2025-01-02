using Demo_OOP_Session_3.Override;

namespace Demo_OOP_Session_3
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, int y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {

            // PolyMorphism
            #region Overloading
            // 1. Overloading - 2. Overriding
            // double result = Sum(1.5,2);
            // Console.WriteLine(result);
            //result = Sum3(5, 6, 7);
            // Console.WriteLine('n');
            //Console.WriteLineint();
            //Console.WriteLinestring();
            //Console.WriteLinechar();
            #endregion
            #region Overriding
            //TypeA a = new TypeA(5);
            //TypeA.A = 100;
            //a.Myfun01();
            //a.Myfun02();

            //TypeB b = new TypeB(10, 20);
            //TypeB.A = 1;
            //TypeB.B = 2;
            //b.Myfun01();
            //b.Myfun02();
            #endregion
            #region Binding
            // Binding is just a Behavior.

            //TypeA Refbase;
            // Declare Refrence from Type A
            // can refer to object from Type A 
            // can refer to object inherited from Type A
            // Refbase = new TypeB(1,2);
            // Refbase.A = 12;
            //Refbase.B = 13; ===.> Error
            //Refbase.Myfun01();
            //Refbase.Myfun02();
            //TypeB refB = (TypeB) new TypeB(1, 2);
            #endregion
        }
    }
}
