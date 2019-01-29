using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_opgave
{
    class Program
    {
        static void Main(string[] args)
        {

            //IDbFunktioner[] array1 = new IDbFunktioner[10];
            //array1[0] = new Ubåd();
            //array1[1] = new Hund();
            //array1[2] = new Hund();
            //array1[3] = new Ubåd();
            //array1[4] = new Ubåd();
            //array1[5] = new Ubåd();
            //array1[6] = new Hund();
            //array1[7] = new Ubåd();


            //foreach (var item in array1)
            //{
            //    item.Gem();
            //}

            Console.WriteLine("-------------------------------");

            List<IDbFunktioner> lst = new List<IDbFunktioner>();
            lst.Add(PickOne());
            //lst.Add(new Ubåd());
            //lst.Add(new Hund());
            //lst.Add(new Hund());
            //lst.Add(new Ubåd());
            //lst.Add(new Hund());
            //lst.Add(new Ubåd());
            //lst.Add(new Ubåd());
            //lst.Add(new Hund());
            //lst.Add(new Ubåd());
            //lst.Add(new Ubåd());
            lst.Add(PickOne());
            lst.Add(PickOne());
            lst.Add(PickOne());
            lst.Add(PickOne());
            lst.Add(PickOne());



            foreach (var item in lst)
            {
                //System.Threading.Thread.Sleep(503);
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


            IDbFunktioner PickOne()
            {
                if (DateTime.Now.Millisecond % 2 == 0)
                {
                    return new Hund();
                }
                else
                    return new Ubåd();
            }
        }

        
    }

    interface IDbFunktioner
    {

        void Gem();
    }
    class Hund : IDbFunktioner
    {
        public string Navn
        {
            get; set;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }
    }

    class Ubåd : IDbFunktioner
    {

        public int Nummer
        {
            get; set;
        }

        public double Tubine
        {
            get; set;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer Tubine");
        }

        
    }

   







}
