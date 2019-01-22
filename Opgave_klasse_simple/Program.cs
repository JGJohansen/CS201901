using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_klasse_simple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Leif", "Andersen", 1978);
            Person p2 = new Person();
            Console.WriteLine($"Fornavn: {p1.Fornavn}. Efternavn: {p1.Efternavn}. Født i år: {p1.Fødselsår}, så personen er {p1.Alder()} (cirka)");
            Console.WriteLine($"Fornavn: {p2.Fornavn}. Efternavn: {p2.Efternavn}. Født i år: {p2.Fødselsår}, så personen er {p2.Alder()} (cirka)");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string Fuldtnavn()
        {

            return $"{this.Fornavn} {this.Efternavn}";
        }

        public int Alder()
        {

            return System.DateTime.Now.Year - this.Fødselsår;
        }

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
            this.Fødselsår = 1999;
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;

            if (System.DateTime.Now.Year - fødselsår < 1 || System.DateTime.Now.Year - fødselsår > 100)
                throw new ApplicationException("Test");
        }

    }
}
