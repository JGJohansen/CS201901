using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_events
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w =
            new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Created += (o, e) => Console.WriteLine("Fil oprettet"+e.Name);

            System.Timers.Timer t = new System.Timers.Timer();
            t.Enabled = true;
            t.Interval = 1000;
            t.Elapsed += (o, e) => Console.WriteLine($"Tæller {e.SignalTime}  {System.Security.Principal.WindowsIdentity.GetCurrent().User}");

            
            do
            {
           
            } while (true);

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil rettet"+e.Name);
        }
    }
}
