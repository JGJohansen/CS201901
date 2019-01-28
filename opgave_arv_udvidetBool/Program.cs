using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_arv_udvidetBool
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   

        }
    }

    class UdvidetRandom : System.Random
    {

        

        public bool NextBool()
        {
            //Random p = new Random();
            if (this.Next(1, 1002) <= 500)
            {
                return true;
            }
            else
                return false;
            

        }


    }
}
