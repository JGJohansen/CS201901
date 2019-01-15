using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler2
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + efternavn;
            string samletNavn1 = $"fornavn {fornavn} efternavn {efternavn}";
            string samletNavn2 = fornavn + " " + efternavn;

            string navnStort = samletNavn2.ToUpper();
            string navnLille = samletNavn2.ToLower();
            string delNavn = samletNavn2.Substring(7, 4);

            Console.WriteLine(samletNavn);
            Console.WriteLine(samletNavn1);
            Console.WriteLine(samletNavn2);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(delNavn);
            string path = @"c:\kode\";
            string fileType = ".txt";
            string linje = "\r\n";

            Console.WriteLine(path);

            System.IO.File.WriteAllText(path+delNavn+fileType, delNavn+linje+navnLille);

            //System.IO.File.WriteAllText()



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
