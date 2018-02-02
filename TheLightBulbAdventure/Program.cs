using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TheLightBulbAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Er vas een een jongen en een meisje.");



            var uriko = new Persoon("Uiko");
            var mako = new Persoon("Mako");

            var ledLanp = new Lamp();
            var zaklamp = new Lamp();

            uriko.Naam = "Mitek";
            mako.Naam = "n/a";

            uriko.Postcode = "666";
            mako.Postcode = "666";

            uriko.Geboortedatum = new DateTime(2000, 1, 1);
            mako.Geboortedatum = new DateTime(2000, 1, 1);

            Console.WriteLine();

            Console.WriteLine("Uri is {0} years.", uriko.Leeftijd);
            Console.WriteLine("Mako is {0} years.", mako.Leeftijd);

            Console.WriteLine();

            Console.WriteLine("De Zaklamp brandt {0}.", zaklamp.Brandend ? "" : "niet");
            zaklamp.Toggle();
            Console.WriteLine("De Zaklamp brandt {0}.", zaklamp.Brandend ? "" : "niet");
        }
    }
}
