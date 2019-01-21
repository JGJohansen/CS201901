using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_simpleKlasser
{
    internal class Program
    {
        internal static void Main(string[] args)
        {

            Person p1 = new Person();
            Console.WriteLine($"{p1.Fornavn} {p1.Efternavn} {p1.Fødselsår}");

            Person p2 = new Person("Leif", "Knudsen", 1973);
            Console.WriteLine($"{p2.Fornavn} {p2.Efternavn} {p2.Fødselsår}");

            Console.WriteLine(p1.Fuldtnavn());
            Console.WriteLine(p2.Fuldtnavn());

            Console.WriteLine(p1.Alder());
            Console.WriteLine(p2.Alder());





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
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Fødselsår = fødselsår;

        }
    }
}
