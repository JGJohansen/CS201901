using System;
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

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Terning
    {

        public int Værdi;
        private bool snyd;
        private static Random rnd = new Random();
        public void Skriv()
        {

            Console.WriteLine("["+this.Værdi+"]");
            ; 
        }

        public int Ryst()
        {
            if (this.snyd == true)
            {
                return this.Værdi = 6;
            }
            else
            {
                return this.Værdi = rnd.Next(1, 7);
            }
            

        }

        public Terning()
        {
            this.Værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.Værdi = 1;
            this.snyd = snyd;
            this.Ryst();
        }
    }
}
