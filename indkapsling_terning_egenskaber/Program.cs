using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indkapsling_terning_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Terning t1 = new Terning();
                Console.WriteLine(t1.Skriv());
                Console.WriteLine(t1.Ryst());
                Console.WriteLine(t1.Skriv());

                Terning t2 = new Terning();
                Console.WriteLine(t2.Skriv());
                Console.WriteLine(t2.Ryst());
                Console.WriteLine(t2.Skriv());

            }

            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   
        }
    }


    public class Terning
    {

        private int _værdi;

        public int Værdi
        {
            get
            {
                System.IO.File.AppendAllText(@"c:\kode\test2.txt",$"{System.DateTime.Now} Værdi aflæses \r\n" );
                //Console.WriteLine("Værdi aflæses");
                return this._værdi;
            }
            set
            {
                System.IO.File.AppendAllText(@"c:\kode\test2.txt", $"{System.DateTime.Now} Værdi tildeles \r\n");
                //Console.WriteLine("Værdi tildeles");
                if (value < 1 || value > 6)
                    this._værdi = 1;
                else
                    this._værdi = value;
            }
        }

        private static Random rnd = new Random();
        
        public int Ryst()
        {

            return this.Værdi = rnd.Next(1,8);

        }

        public string Skriv()
        {

            return $"[{this.Værdi}]";
        }






    }
}
