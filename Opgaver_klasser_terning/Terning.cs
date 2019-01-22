using System;

namespace Opgaver_klasser_terning
{
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
                // husk at tilføje hvad det er den skal returnere til. ikke bare hvad den skal returnere -.-
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
