using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
    public class Narudzba
    {

        public int brojNarudzbe { get; set; }
        public DateTime datumNarucivanja { get; set; }
        public DateTime datumDostave { get; set; }
        public Korisnik korisnik { get; set; }
        public string adresaDostave { get; set; }
        public double iznosNarudzbe { get; set; }
        public List<Lijek> spisakLijekova { get; set; }

        public Narudzba(
            int brojNarudzbe,
            DateTime datumNarucivanja,
            DataTime datumDostave,
            Korisnik korisnik,
            string adresaDostave,
            double iznosNarudzbe,
            List<Lijek> spisaklijekova)
        {

            this.brojNarudzbe = brojNarudzbe;
            this.datumNarucivanja = datumNarucivanja;
            this.datumNarucivanja = datumNarucivanja;
            this.datumDostave = datumDostave;
            this.korisnik = korisnik;
            this.adresaDostave = adresaDostave;
            this.iznosNarudzbe = iznosNarudzbe;
            this.spisakLijekova = spisakLijekova;
        }


    }
}
