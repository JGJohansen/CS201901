using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstanter_structurer_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            KortKulør kortKulør1 = KortKulør.Hjerter;
            int kortVærdi1 = Convert.ToInt32(kortKulør1);

          
            Console.WriteLine(kortKulør1);
            Console.WriteLine(kortVærdi1);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
