using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programflow_opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                
                if (i % 3 != 0)
                
                    continue;

                if (i > 15)

                    break;

                Console.WriteLine(i);
                
                


            }


            for (int q = 0; q < 11; q++)
            {
                if (q == 4 || q == 5)
                    continue;
                if (q == 8)
                    break;

                Console.WriteLine(q);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
