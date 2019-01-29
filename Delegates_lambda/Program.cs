using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine(a.FindIndex(Find));
            Console.WriteLine(a.FindIndex((int i) => { return i == 51; }));
            Console.WriteLine(a.FindIndex(i => { return i == 51;}));
            Console.WriteLine(a.FindIndex(i =>  i == 51));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        static bool Find(int værdi)
        {

            return  værdi == 51;
        }
    }
}
