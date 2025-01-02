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
            Console.WriteLine('n');
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
        }
    }
}
