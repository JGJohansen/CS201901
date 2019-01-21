using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_structvsclass
{
    class Program
    {
        static void Main(string[] args)
        {

            Person k1 = new Person();
            Person k2 = new Person();

            k1.navn = "a";
            k2.navn = "b";

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            k1 = k2;

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            k1.navn = "c";

            Console.WriteLine(k1.navn);
            Console.WriteLine(k2.navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            //Struct vil skrive a b b b c b
            //Class vil skrive a b b b c c

            // Struct lagrer værdien i stack, så når k1.navn i anden omgang opdaters til c selvom k1 = k2 tidligere, så er det kun k1.navn der er opdateret til c, men k2.navn fortsat vil vise b.
            // I class er det referencer til heap, så ved k1 = k2, vil de 2 referencer ikke længere pege på 2 men en ting i heap, hvor det k1 oprindeligt pegede på vil komme ud af brug og garbage
            // collector vil fjerne samme. 

        }
    }

    class Person
    {
        public String navn;

    }
}
