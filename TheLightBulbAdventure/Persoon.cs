using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLightBulbAdventure
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Postcode { get; set; }
        public DateTime Geboortedatum { get; set; }
        public int Leeftijd {
            get
            {
                var ts = DateTime.Now - Geboortedatum;
                return (int)(ts.TotalDays / 365);
            }
        }


    }
}
