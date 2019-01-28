using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Almindelig Terning");
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            Console.WriteLine();
            Console.WriteLine("Ludo Terning1 ");
            LudoTerning t2 = new LudoTerning(8);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            Console.WriteLine(t2.ErGlobus());
            Console.WriteLine(t2.ErStjerne());
            Console.WriteLine();
            Console.WriteLine("Ludo Terning 2");
            LudoTerning t3 = new LudoTerning();
            t3.Skriv();
            Console.WriteLine(t3.ErGlobus());
            Console.WriteLine(t3.ErStjerne());
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

