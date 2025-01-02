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

            // poly Morphism
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
        }
    }
}
