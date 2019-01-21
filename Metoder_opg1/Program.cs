using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_opg1
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double areal = BeregnAreal(2.5);
            Console.WriteLine(areal);

            Udskriv("Dette er en test");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static int LægSammen(int a, int b){

            int z = a + b;
            return z;

        }

        static double BeregnAreal(double radius) {
            double z = 2 * radius * Math.PI;

            return z;
        }

        static void Udskriv(string txt) {
            
            Console.WriteLine(txt);
        }
        
    }
}
