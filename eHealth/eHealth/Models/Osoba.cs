using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel


namespace eHealth.Models
{
    public abstract class Osoba
    {
        public string  ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string lozinka { get; set; }
        public string kontaktTelefon { get; set; }
        public string emailAdresa { get; set; }


        public Osoba(string ime, string prezime, DateTime datumRodjenja, string lozinka, string kontakTelefon, string emailAdresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.lozinka = lozinka;
            this.kontaktTelefon = kontaktTelefon;
            this.emailAdresa = emailAdresa;

        }


    }
}
