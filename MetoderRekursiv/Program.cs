using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderRekursiv
{
    class Program
    {
        static void Main(string[] args)
        {

            LøkkeSomMetode(1,50 );
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void LøkkeSomMetode(int start, int stop)
        {
            Console.WriteLine(start);

            if (start == stop)
                return;
            start++;
            LøkkeSomMetode(start, stop);

           
        }


    }



}
