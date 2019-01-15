using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konst_enum_structenum
{
    class Program
    {
        static void Main(string[] args)
        {

            SpilleKort s1 = new SpilleKort();
            s1.Værdi = 2;
            s1.Kulør = Kulør.Spar;
            Console.WriteLine($"{s1.Kulør} {s1.Værdi}");

            SpilleKort s2 = new SpilleKort();
            s2.Værdi = 10;
            s2.Kulør = Kulør.Hjerter;
            Console.WriteLine($"{s2.Kulør} {s2.Værdi}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }//comment

        //comment test github
    }


    public struct SpilleKort
    {

       public int Værdi;
       public Kulør Kulør;

    }

    public enum Kulør
    {
        Hjerter,
        Spar, 
        ruder,
        klør

    }
}
