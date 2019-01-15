using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabler2_datoformatering
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            d1 = d1.AddDays(10);

            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2 = DateTime.Now;

            DateTime d3 = new DateTime(2019, 01, 01);

            Console.WriteLine(d2);
            Console.WriteLine(d3);

            TimeSpan timeDiff = d2.Subtract(d3);
            Console.WriteLine(timeDiff);

            Console.WriteLine(timeDiff.Days);

            TimeSpan t3 = new TimeSpan(16, 00, 00);

            Console.WriteLine(t3);

            Console.WriteLine();




          
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
