using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[6];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 7, Navn = "Fido" };
            hunde[3] = new Hund() { Alder = 9, Navn = "Mille" };
            hunde[4] = new Hund() { Alder = 11, Navn = "Centa" };
            hunde[5] = new Hund() { Alder = 15, Navn = "Laika" };
            Array.Sort(hunde);
            Array.Reverse(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn + " - " + item.Alder);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Hund : IComparable<Hund>
    {
        public string Navn
        {
            get; set;
        }
        public int Alder
        {
            get; set;
        }

        public int CompareTo(Hund other)
        {
            //return this.Alder.CompareTo(other.Alder);

            if (this.Alder > other.Alder)
                return 1;
            if (this.Alder < other.Alder)
                return -1;
            else
                return 0;
        }
    }
}
