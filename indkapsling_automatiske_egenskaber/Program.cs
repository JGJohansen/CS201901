using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indkapsling_automatiske_egenskaber
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "Bo";
            p1.Efternavn = "L";
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.FuldtNavnEgenskab);
            




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    public class Person
    {

        public string Fornavn
        {
            get; set;
        }

        private string _efternavn;

        public string Efternavn
        {
            get
            {
                return this._efternavn;
            }
            set
            {
                if (value.Length <= 3)
                {
                    this._efternavn = "";
                }
                else
                {
                    this._efternavn = value;
                }
            }
        }
        public string FuldtNavn()
        {

            return $"{this.Fornavn} {this.Efternavn}";
        }

        private string _fuldtNavnEgenskab;

        public string FuldtNavnEgenskab
        {
            get
            {
                return $"{this.Fornavn} {this.Efternavn}";
            }
        }


    }
}
