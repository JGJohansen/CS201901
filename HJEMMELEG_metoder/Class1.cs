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

           


            string value1 = Console.ReadLine();
            
            string value2 = Console.ReadLine();
            //string value3 = Console.ReadLine();
            //string value4 = Console.ReadLine();
            //string value5 = Console.ReadLine();

            int test = Metoder.Metode1(Convert.ToInt32(value1), Convert.ToInt32(value2));
            Console.WriteLine(test);

           

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        
    }
}
