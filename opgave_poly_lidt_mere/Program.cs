using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_poly_lidt_mere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hund h1 = new Hund() { Navn = "Mille" };
            //h1.SigNoget();

            //Kat k1 = new Kat() { Navn = "Freja" };
            //k1.SigNoget();

            //Console.WriteLine();

            //List<Dyr> blanding = new List<Dyr>();
            //blanding.Add(new Kat(){ Navn = "Kattenavn1"});
            //blanding.Add(new Kat() { Navn = "Kattenavn2" });
            //blanding.Add(new Hund() { Navn = "Hundenavn1" });
            //blanding.Add(new Hund() { Navn = "Hundenavn2" });
            //blanding.Add(new Kat() { Navn = "Kattenavn3" });
            //blanding.Add(new Hund() { Navn = "Hundenavn3" });

            //foreach (Dyr item in blanding)
            //{
            //    item.SigNoget();
                    
            //}

            Console.WriteLine();

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }

    abstract class Dyr
    {
        public string Navn
        {
            get; set;
        }

        private static System.Random rnd = new Random();

        public static Dyr TilfældigtDyr()
        {
            
            string data = System.IO.File.ReadAllText(@"c:\kode\navne.txt", System.Text.Encoding.Default);
           
            //string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            //data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            //data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            //data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }



        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Vov, Jeg er en Hund og hedder {Navn}");
            //base.SigNoget();
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Miaw, Jeg er en Kat og hedder {Navn}");
            //base.SigNoget();
        }
    }
}
