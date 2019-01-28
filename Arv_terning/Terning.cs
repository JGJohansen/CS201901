using System;

namespace Arv_terning
{
    public class Terning
    {

        private int _værdi;
        private static System.Random rnd;

        static Terning()
        {
            rnd = new Random();
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            Ryst();
        }

        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public int Værdi
        {
            get
            {
                // .....
                //Console.WriteLine($"Værdi Aflæses ({_værdi})");
                System.IO.File.AppendAllText(@"c:\kode\test.txt",$"{System.DateTime.Now} Værdi læses ({_værdi}) \r\n");
                return _værdi;
            }
            set
            {
                // log
                //Console.WriteLine($"Værdi tildeles ({_værdi})");
                System.IO.File.AppendAllText(@"c:\kode\test.txt", $"{System.DateTime.Now} Værdi tildeles ({_værdi}) \r\n");
                if (value <= 0 || value > 6)
                {
                    System.IO.File.AppendAllText(@"c:\kode\test.txt", $"{System.DateTime.Now} Nogen prøvede at bruge den falske terning \r\n");
                    throw new ApplicationException("Forkert terning");
                    
                }
                this._værdi = value;
            }
        }

        


    }
}

