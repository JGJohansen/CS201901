using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJEMMELEG_metoder
{
    class Program
    {

        static void Main(string[] args)
        {

            int test = Metoder.Metode1(4, 2);
            Console.WriteLine(test);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        
    }
}
