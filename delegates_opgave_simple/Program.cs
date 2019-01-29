using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_opgave_simple
{

    public delegate void MinDelegate1(string txt);
    public delegate int MinDelegate2(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {

            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("Test1");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2.Invoke("Test2");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("Test3");

            //f1 -= MinSkrivTilConsole;
            //f2 -= MinSkrivTilConsole;
            //f3 -= MinSkrivTilConsole;
            //f3 -= Console.WriteLine;

            f1("Test");

            MinDelegate2 d1 = TestSomethingDelegate.Beregner;
            d1(1, 2);
            



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }

    class TestSomethingDelegate
    {
        public static int Beregner(int a, int b)
        {
            Console.WriteLine(a+b);
            return a + b;
        }

    }
}
