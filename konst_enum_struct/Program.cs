using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konst_enum_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.id = 1;
            v1.navn = "Vare #1";
            v1.beskrivelse = "Min beskrivelse til #1";
            v1.pris = 100;
            Console.WriteLine($"{v1.navn} koster {v1.pris:N2}");

            Vare v2 = new Vare();
            v2.id = 2;
            v2.navn = "Vare #2";
            v2.beskrivelse = "Min beskrivelse til #2";
            v2.pris = 200;
            Console.WriteLine($"{v2.navn} koster {v2.pris:N2}");

            Vare v2Kopi = v2;
            Console.WriteLine($"{v2Kopi.navn} koster {v2Kopi.pris:N2}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


}
