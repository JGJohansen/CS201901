using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatiskMetodeOpgave
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Navn = "a";
            p.Alder = 11;

            p.Udskriv();

            bool res = Person.ValiderCpr("111111111");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    struct Person
    {
        public string Navn;
        public int Alder;

        public void Udskriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {Alder} gammel");

        }

        public static bool ValiderCpr(string cpr) {

            return true;

        }

    }
}
