using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_array_test
{
    class Program
    {
        static void Main(string[] args)
        {


            string test = "j;k;f";

            string[] test1 = test.Split(';');
            foreach (var item in test1)
            {
                Console.WriteLine(item);
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
