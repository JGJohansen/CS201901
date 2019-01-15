using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variablertaldel2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            
           
            double result = System.Convert.ToDouble(tal1) + System.Convert.ToDouble(tal2);
            Console.WriteLine(result.ToString("N2"));
          //  Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
