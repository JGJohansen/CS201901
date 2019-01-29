using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double sum = 0;
            Console.WriteLine("Liste med løninger ( ikke sorteret )");
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
                
            }

            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                
            }
            Console.WriteLine($"Summen er = {sum:N2}");
            Console.WriteLine($"Gennemsnittet er = {sum/månedsløn.Length:N2}");

            int[] b = månedsløn.Clone() as int[];

            Console.WriteLine("Sorteret liste med lønninger");
            System.Array.Sort(b);
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }
            


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
