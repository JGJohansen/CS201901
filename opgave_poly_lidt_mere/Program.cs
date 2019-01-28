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
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Dyr
    {

    

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en Hund og hedder {Navn}");
            //base.SigNoget();
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en Kat og hedder {Navn}");
            //base.SigNoget();
        }
    }
}
