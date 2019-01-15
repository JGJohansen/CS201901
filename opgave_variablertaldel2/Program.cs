using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variablertaldel2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            //Der er mange muligheder. Man kan definere de enkelte variabler hvis man skal bruge dem igen, hvis man deriomod kun skal bruge resultatet igen så kan man definere resultatet istedet.
            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);
           
            //her er resultatet sat som variable
            double result = System.Convert.ToDouble(tal1) + System.Convert.ToDouble(tal2);

            // herefter printet på forskellige måder
            Console.WriteLine(result.ToString("N2"));
            Console.WriteLine(t1+t2);
            Console.WriteLine(result);
            Console.WriteLine(System.Convert.ToDouble(tal1)+ System.Convert.ToDouble(tal2));

            string dd = "something something";

            Console.WriteLine(dd.ToUpperInvariant());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }




    }


}
