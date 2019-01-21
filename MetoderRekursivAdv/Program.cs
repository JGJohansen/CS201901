using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderRekursivAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            string stien = @"C:\Users\admin\Desktop";

            PrintFiler(stien);

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   
        }

        static void PrintFiler(string sti)
        {
            var filer = System.IO.Directory.GetFiles(sti);
            foreach (string fil in filer) { 
                Console.WriteLine(fil);
                System.IO.File.AppendAllText(@"c:\temp\resultat.txt", fil+"\r\n");
            }

            var mapper = System.IO.Directory.GetDirectories(sti);
            foreach (string mappe in mapper)
                PrintFiler(mappe);


        }
    }
}
