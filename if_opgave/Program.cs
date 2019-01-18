using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 21; yy++)
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //Console.WriteLine("\n \n");
            //Console.WriteLine("Test");


            //for (int q = 0; q < 11; q++)
            //{

            //    int[] tal2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    Console.WriteLine(tal2);

            //}

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            
        }

        
    }


}
