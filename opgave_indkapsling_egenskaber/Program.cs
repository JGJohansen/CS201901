using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_indkapsling_egenskaber
{
    public class Program
    {
        static void Main(string[] args)
        {

            Vare v1 = new Vare();
            Vare v2 = new Vare("Kop", 25.5);
            Vare v3 = new Vare("Kop", -1);


            Console.WriteLine($"{v1.Navn} - {v1.PrisMedMoms()}");
            Console.WriteLine($"{v2.Navn} - {v2.PrisMedMoms()}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

}
