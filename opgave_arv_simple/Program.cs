using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_arv_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Fornavn = "Bo";
            p1.Efternavn = "Andersen";

            Console.WriteLine(p1.Fuldtnavn());

            Elev p2 = new Elev();

            p2.Fornavn = "Elev1";
            p2.Efternavn = "EfternavnElev1";

            Console.WriteLine(p2.Fuldtnavn());

            Instruktør p3 = new Instruktør();
            p3.Fornavn = "Instruktør1";
            p3.Efternavn = "IntruktørEfternavn1";
            Console.WriteLine(p3.Fuldtnavn());

            Elev p4 = new Elev() { Fornavn = "Rolf", Efternavn = "Andersen", Klasselokale = "Nr 4"};
            Console.WriteLine(p4.Fuldtnavn());
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {

        public string Fornavn
        {
            get; set;
        }

        public string Efternavn
        {
            get; set;
        }

       public string Fuldtnavn()
        {

            return $"{Fornavn} {Efternavn}";
        }


    }
    class Elev : Person
    {
        public string Klasselokale
        {
            get; set;
        }


    }

    class Instruktør : Person
    {
        public int NøgleId
        {
            get; set;
        }
    }



}
