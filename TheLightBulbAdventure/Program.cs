using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLightBulbAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var uriko = new Persoon();
            var mako = new Persoon();

            uriko.Voornaam = "Uriko";
            mako.Voornaam = "Mako";

            uriko.Naam = "Mitek";
            mako.Naam = "n/a";

            uriko.Postcode = "666";
            mako.Postcode = "666";

            uriko.Geboortedatum = new DateTime(2000, 1, 1);
            mako.Geboortedatum = new DateTime(2000, 1, 1);

            Console.WriteLine("Uri is {0} years.", uriko.Leeftijd);


        }
    }
}
