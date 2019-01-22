using System;

namespace opgave_indkapsling_egenskaber
{
    public class Vare
    {
    
        private string _navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Navn hentes");
                return this._navn;
            }
            set
            {
                Console.WriteLine("Navn tildeles");
                this._navn = value;
            }
        }

        private double _pris;

        public double Pris
        {
            get
            {
                Console.WriteLine($"Pris hentes");
                return this._pris;
                
            }
            set
            {
                if (value < 0)
                {
                    System.IO.File.AppendAllText(@"c:\kode\test.txt", $"{DateTime.Now} Nogen lavede et eller andet \r\n");
                    throw new ApplicationException("Den skal ikke foræres væk!");
                }
                else
                {
                
                Console.WriteLine($"Pris tildeles");
                this._pris = value;
                }
            }
        }

        public double PrisMedMoms()
        {

            return this._pris * 1.25;
        }

        public Vare()
        {
            this.Navn = "Vare Uden Navn";
            this.Pris = 10;
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
    }

}
