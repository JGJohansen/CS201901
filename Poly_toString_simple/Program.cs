using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_toString_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f1 = new Faktura();
            Console.WriteLine(f1);

            Faktura f2 = new Faktura() { Kunde = "LM", Nr = 1, Dato = DateTime.Now };
            Console.WriteLine(f2);

            SpecialFaktura f3 = new SpecialFaktura() { Kunde = "Telia", Nr = 2, Dato = DateTime.Now};
            Console.WriteLine(f3);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    class Faktura
    {

        public int Nr
        {
            get; set;
        }

        public DateTime Dato
        {
            get; set;
        }

        public string Kunde
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Faktura til {Kunde} Nr {Nr} fra {Dato}";

            //return base.ToString();
        }

        public Faktura()
        {

        }

        public Faktura(string Kunde, int Nr, DateTime Dato)
        {

        }




    }

    class SpecialFaktura : Faktura
    {
        public override string ToString()
        {
            return $"Special Faktura til {Kunde} Nr {Nr} fra {Dato}";

            //return base.ToString();
        }

    }
}
