using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_lister
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> liste = new Dictionary<int, string>();
            liste.Add(1, "Leif");
            liste.Add(2, "Bo");
            liste.Add(3, "Rolf");

            foreach (var item in liste)
            {
                Console.WriteLine(item.Value);
            }

            List<Person> lp1 = new List<Person>();
            List<Person> lp2 = new List<Person>();
            List<Person> lp3 = new List<Person>();

            lp1.Add(new Person(1,"Leif"));
            lp1.Add(new Person(2, "Bo"));
            lp1.Add(new Person(3, "Rolf"));

            foreach (var item in lp1)
            {
                Console.WriteLine(item.Navn);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {

        public int Id
        {
            get; set;
        }

        public string Navn
        {
            get; set;
        }

        public Person(int id, string navn)
        {
            this.Id = id;
            this.Navn = navn;
        }



    }
}
