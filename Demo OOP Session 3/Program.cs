using Demo_OOP_Session_3.Interfaces;
using Demo_OOP_Session_3.Override;

namespace Demo_OOP_Session_3
{
    internal class Program
    {
        #region
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        //public static double Sum(double x, int y)
        //{
        //    return x + y;
        //}
        //public static double Sum(int x, double y)
        //{
        //    return x + y;
        //}
        #endregion

        public static void PrinNumber(ISeries series)
        {
            if (series is not null)
            {
               for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();

                }
               series.Reset();

            }

            static void Main(string[] args)
        {

           

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

            #region  Binding ex2 [Adavanced] 
            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 6;
            //typeA.Myfun01(); // I am Parent
            //typeA.Myfun02(); // A = 6 , B = 2 , C = 3

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 8;
            //typeB.B = 9;
            //typeB.Myfun01(); // I am Child
            //typeB.Myfun02(); // A = 8 , B = 9 , C = 3
            #endregion

            #region Interface

            //IMytype mytype;
            //mytype = new IMytype(); //===== Invalid because cannot create object from interface

            //Mytype mytype = new Mytype();
            //mytype.Id = 5;
            //mytype.fun();
            //mytype.Print();


            IMytype mytype;
            mytype = new Mytype();
            mytype.Id = 5;
            mytype.fun();
            mytype.Print();

                #endregion

            #region Example Interface
                //// 0 2 4 6 8 10 
                //// 0 3 6 9 12 
                //// 0 4 8 12 
                //Seriesbytwo seriesbytwo = new Seriesbytwo();
                //PrinNumber(seriesbytwo);

                //SeriesBythree seriesBythree = new SeriesBythree();
                //PrinNumber(seriesBythree);
                #endregion

        
               

            }
        }
}
}
