﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_klasser_terning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Console.WriteLine(t2.Værdi);
            Console.WriteLine(t1.Værdi);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
